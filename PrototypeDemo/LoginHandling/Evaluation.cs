using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginHandling
{
    public class Evaluation
    {
        int evaluationId;
        int userId;
        int restaurantId;
        int moodRating;
        public Evaluation(int Evaluation, int User, int Restaurant, int Rating)
        {
            evaluationId = Evaluation;
            userId = User;
            restaurantId = Restaurant;
            moodRating = Rating;
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
        
        public int getMoodRating()
        {
            return this.moodRating;
        }
        
        

        public static void ShowEvaluations ()
        {
            List<Evaluation> evaluationList = DataBase.GetEvaluationList();
            foreach(Evaluation element in evaluationList)
            {
                Console.WriteLine("{0} {1} {2} {3}", element.getEvaluationId(), element.getUserId(), element.getRestaurantId(), element.getMoodRating());
           
            }
        }
        
    }
}
