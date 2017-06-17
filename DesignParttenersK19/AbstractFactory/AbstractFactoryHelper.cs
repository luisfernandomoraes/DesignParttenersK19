using System;

namespace DesignParttenersK19.AbstractFactory
{
    public class AbstractFactoryHelper
    {
        /// <summary>
        /// This method simulate the operation in the programs flow.
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public static ICommunicatorFactory GetComunicadorFactory(Card card)
        {
             string bandeira = card.Flag;
             string className = bandeira + "CommunicatorFactory";
             return (ICommunicatorFactory)System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(className);
        }
    }

    public class Card
    {
        public string Flag { get; set; }
    }
}