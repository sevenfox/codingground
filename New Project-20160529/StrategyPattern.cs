using System.IO;
using System;

 public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Test");
            ShoppingMall shopmall = new ShoppingMall(new SalePrice());
            Console.WriteLine(shopmall.ObjStrat.GetBillAmount(100).ToString());
        }
    }
    
    public class ShoppingMall
    {
        public IStrategy ObjStrat;
        public ShoppingMall(IStrategy iStrat)
        {
            ObjStrat = iStrat ;
        }
    }
    
    
    public interface IStrategy
    {
        double GetBillAmount(double billAmount);
    }
    
    public class RegularPrice : IStrategy
    {
        public double GetBillAmount(double billAmount)
        {
            return billAmount;
        }
        
    }
    
    public class SalePrice : IStrategy
    {
        public double GetBillAmount(double billAmount)
        {
            return billAmount - (billAmount *.25);
        }
        
    }
    
    public class StrategyPrice
    {
        public StrategyPrice(IStrategy strat)
        {
            //test
        }
        
    }
    