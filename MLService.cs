using AI_EstimateManday.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_EstimateManday
{
  public  class MLService
    {
        double[] weights;
      
        public MLService()
        {
            Random ran = new Random();
            weights = new double[] { ran.NextDouble(), ran.NextDouble(), ran.NextDouble(), ran.NextDouble() };
        }
        public double Predict(double[] inputs)
        {
            double sum_weigth = SumWeight(inputs);
            return Activation(sum_weigth);
           
        }
        public double[] Train(List<MandayDataSet> dataset,int number_iteration)
        {
            for (int iteration = 0; iteration < number_iteration; iteration++)
            {
                foreach (MandayDataSet dataItem in dataset)
                {
                    double predict = Predict(dataItem.Inputs.ToArray());
                    double error = ErrorCost(dataItem.Output, predict);
                    for (int i = 0; i < this.weights.Length; i++)
                    {
                        double input = dataItem.Inputs[i];
                        this.weights[i] = AdjustWeigth(input, error, predict);
                    }
                }
            }
            return this.weights;
        }
        private double SumWeight(double[] inputs)
        {
           double   sum_input_weight = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                sum_input_weight += inputs[i] * this.weights[i];
            }
            return sum_input_weight;
        }
        private double Activation(double sum_weight)
        {
            //Sigmoid
            return 1 / (1 + Math.Exp(-sum_weight));
        }
        private double ErrorCost(double output,double predict)
        {
            return output - predict;
        }
        private double AdjustWeigth(double input,double error,double predict)
        {
            //Signoid gradient
            double gradient = predict * (1 - predict);
            double new_weight = input * error * gradient;
            return new_weight;
        }

    }
}
