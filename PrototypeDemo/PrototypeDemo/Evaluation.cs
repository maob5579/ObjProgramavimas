using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDemo
{
    public class Evaluation
    {
        int evaluationId;
        int userId;
        int restaurantId;
        double moodRating;
        int Price;
        int Experience;
        public Evaluation(int Evaluation, int User, int Restaurant, double Rating, int prc, int exp)
        {
            evaluationId = Evaluation;
            userId = User;
            restaurantId = Restaurant;
            moodRating = Rating;
            Price = prc;
            Experience = exp;
        }
        public int getEvaluationId()
        {
            return this.evaluationId;
        }

        public int getUserId()
        {
            return this.userId;
        }
        public int getRestaurantId()
        {
            return this.restaurantId;
        }
        
        public double getMoodRating()
        {
            return this.moodRating;
        }
        
        public int getPrice()
        {
            return this.Price;
        }

        public int getExperience()
        {
            return this.Experience;
        }
        
        

    
        
    }
}
