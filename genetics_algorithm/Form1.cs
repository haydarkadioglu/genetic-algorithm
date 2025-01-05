using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot.Axes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace genetics_algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializePlotView();
        }

        private int populationSize, elitePercentage, chromosomeLength, generationCount;
        private double crossoverRate;
        private double mutationRate;

        
        private List<double> fitnessOverGenerations = new List<double>();
        private OxyPlot.WindowsForms.PlotView plotView;

        private void InitializePlotView()
        {
            plotView = new PlotView();
            plotView.Dock = DockStyle.Fill; 
            Controls.Add(plotView); 
        }
        private void button_start_Click(object sender, EventArgs e)
        {
            populationSize = Convert.ToInt32(textBox_population.Text);
            crossoverRate = Convert.ToDouble(textBox_crossover.Text);
            mutationRate = Convert.ToDouble(textBox_mutation.Text);
            elitePercentage = Convert.ToInt32(textBox_elite.Text);
            generationCount = Convert.ToInt32(textBox_generation.Text);
            chromosomeLength = Convert.ToInt32(textBox_chromosome.Text);

            var ga = new GeneticAlgorithm(populationSize, chromosomeLength, crossoverRate, mutationRate, elitePercentage);

            
            List<double> bestIndividual = ga.GeneticAlgorithmOptimize(generationCount);
            bestIndividual.Sort();
            bestIndividual.Reverse();

            
            
            ShowResult(bestIndividual);

            PlotConvergence1(bestIndividual);



        }

        private void ShowResult(List<double> bestIndividual)
        {
            
            listBox1.Items.Clear();

            
            listBox1.Items.Add("En iyi bireyin uygunluğu: " + CalculateFitness(bestIndividual).ToString("F2"));

            foreach (var individual in bestIndividual)
            {
                listBox1.Items.Add("Birey: " + individual.ToString("F2"));
            }
        }

        private double CalculateFitness(List<double> individual)
        {
            double fitness = 0;
            for (int i = 0; i < individual.Count - 1; i++)
            {
                fitness += 100 * Math.Pow((individual[i + 1] - Math.Pow(individual[i], 2)), 2) + Math.Pow((individual[i] - 1), 2);
            }
            return fitness;
        }

        private void PlotConvergence1(List<double> bestIndividual)
        {
            if (!groupBox1.Controls.Contains(plotView))
            {
                groupBox1.Controls.Add(plotView); 
            }

            var plotModel = plotView.Model ?? new PlotModel { Title = "Yakınsama" };

            plotModel.Series.Clear(); 
            plotModel.Axes.Clear(); 

            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Kromozom uzunluğu",
            });

            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                MajorStep = 0.5,
                Title = "Uygunluk",
            });

            var lineSeries = new LineSeries();

            for (int i = 0; i < bestIndividual.Count; i++)
            {
                lineSeries.Points.Add(new DataPoint(i, bestIndividual[i]));
            }

            plotModel.Series.Add(lineSeries);

            plotView.Model = plotModel;
            plotView.InvalidatePlot(true);
        }


    }
}




class GeneticAlgorithm
{
    private int populationSize, elitismCount, chromosomeLength;
    private double crossoverRate, mutationRate;
    private List<double> fitnessOverGenerations = new List<double>(); 

    public GeneticAlgorithm(int populationSize, int chromosomeLength, double crossoverRate, double mutationRate, int elitismCount)
    {
        this.populationSize = populationSize;
        this.chromosomeLength = chromosomeLength;
        this.crossoverRate = crossoverRate;
        this.mutationRate = mutationRate;
        this.elitismCount = elitismCount;
    }

    private List<double> InitializeChromosome()
    {
        var chromosome = new List<double>();
        var rng = new Random();
        for (int i = 0; i < chromosomeLength; i++)
        {
            chromosome.Add(rng.NextDouble() * 10 - 5); 
        }
        return chromosome;
    }

    private List<List<double>> InitializePopulation()
    {
        var population = new List<List<double>>();
        for (int i = 0; i < populationSize; i++)
        {
            population.Add(InitializeChromosome());
        }
        return population;
    }

    private double CalculateFitness(List<double> individual)
    {
        double fitness = 0;
        for (int i = 0; i < individual.Count - 1; i++)
        {
            fitness += 100 * Math.Pow((individual[i + 1] - Math.Pow(individual[i], 2)), 2) + Math.Pow((individual[i] - 1), 2);
        }
        return fitness;
    }

    private List<List<double>> SelectParents(List<List<double>> population)
    {
        var parents = new List<List<double>>();
        var rng = new Random();

        for (int i = 0; i < 2; i++) // Select two parents
        {
            var tournament = new List<List<double>>();
            for (int j = 0; j < 3; j++) // Tournament size of 3
            {
                tournament.Add(population[rng.Next(populationSize)]);
            }
            var fittestInTournament = tournament.OrderBy(x => CalculateFitness(x)).First();
            parents.Add(fittestInTournament);
        }

        return parents;
    }


    private List<double> Crossover(List<double> parent1, List<double> parent2)
    {
        var rng = new Random();
        var crossoverPoint = rng.Next(chromosomeLength);
        var child = parent1.Take(crossoverPoint).Concat(parent2.Skip(crossoverPoint)).ToList();
        return child;
    }

    private List<double> Mutate(List<double> individual)
    {
        var rng = new Random();
        for (int i = 0; i < chromosomeLength; i++)
        {
            if (rng.NextDouble() < mutationRate)
            {
                individual[i] += rng.NextDouble() - 0.5; 
            }
        }
        return individual;
    }

    public List<double> GeneticAlgorithmOptimize(int generations)
    {
        var population = InitializePopulation();
        for (int i = 0; i < generations; i++)
        {
            var newPopulation = new List<List<double>>();
            for (int j = 0; j < elitismCount; j++)
            {
                var fittest = population.OrderBy(x => CalculateFitness(x)).First();
                newPopulation.Add(fittest);
            }

            while (newPopulation.Count < populationSize)
            {
                var parents = SelectParents(population);
                var offspring = Crossover(parents[0], parents[1]);
                offspring = Mutate(offspring);
                newPopulation.Add(offspring);
            }

            population = newPopulation;


            var fittestIndividual = population.OrderBy(x => CalculateFitness(x)).First();
            fitnessOverGenerations.Add(CalculateFitness(fittestIndividual));
        }

        var bestIndividual = population.OrderBy(x => CalculateFitness(x)).First();
        return bestIndividual;
    }

}
