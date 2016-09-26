using System;
using System.Collections.Generic;

namespace _09_Portfolio
{
    public class Stock : IAsset
    {
        public int NumShares { get; internal set; }
        public double PricePerShare { get; internal set; }
        public string Symbol { get; internal set; }

        public Stock() {

        }
        public Stock(string symbol, double price, int num) {
            this.NumShares = num;
            this.PricePerShare = price;
            this.Symbol = symbol;
        }
        public double GetValue() {
            return this.NumShares * this.PricePerShare;
        }

        public override string ToString() {

            return "Stock[symbol=" + this.Symbol + ",pricePerShare=" + this.PricePerShare + ",numShares=" + this.NumShares + "]";
        }

        public override bool Equals(object obj) {
            Stock other = obj as Stock;
            return this.Symbol.Equals(other.Symbol) && 
                   this.PricePerShare == other.PricePerShare && 
                   this.NumShares == other.NumShares;
        }
        internal static double TotalValue(IAsset[] assets) {
            //return Portfolio.TotalValue(stocks);
            double result = 0.0;
            foreach(IAsset asset in assets) {
                result = result + asset.GetValue();
            }
            return result;
        }
    }
}