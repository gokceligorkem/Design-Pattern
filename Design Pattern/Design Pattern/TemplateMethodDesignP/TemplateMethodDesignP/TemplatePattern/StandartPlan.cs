﻿namespace TemplateMethodDesignP.TemplatePattern
{
    public class StandartPlan : Netflixplan
    {
        public override string Content(string content)
        {
            return content;
        }

        public override int CountPerson(int countPerson)
        {
            return countPerson;
        }

        public override string PlanType(string planType)
        {
            return planType;
        }

        public override double Price(double price)
        {
            return price;
        }

        public override string Resolution(string resolution)
        {
            return resolution;
        }
    }
}
