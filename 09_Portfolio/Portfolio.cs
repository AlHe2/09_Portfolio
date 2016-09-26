using System;
using System.Collections.Generic;

namespace _09_Portfolio
{
    internal class Portfolio
    {
        private List<IAsset> assets;

        public Portfolio(List<IAsset> assets) {
            this.assets = assets;
        }

        public Portfolio() : this(new List<IAsset>()) {

        }

        internal static double TotalValue(IAsset[] portfolio) {
            double result = 0.0;
            foreach(IAsset asset in portfolio) {
                result = result + asset.GetValue();
            }
            return result;
        }

        internal double GetTotalValue() {
            return Portfolio.TotalValue(assets.ToArray());
        }

        internal void AddAsset(IAsset asset) {
            this.assets.Add(asset);
        }
    }
}