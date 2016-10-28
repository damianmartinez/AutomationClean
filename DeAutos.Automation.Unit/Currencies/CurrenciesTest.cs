using DeAutos.Automation.Model.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace DeAutos.Automation.Unit.Currencies
{
    [TestClass]
    public class CurrenciesTest
    {
        public void Get_All_Currencies()
        {
            DeAutosEntities db = new DeAutosEntities();

            List<Currency> currencies = db.Currencies.ToList();

            IsNotNull(currencies);
            IsTrue(currencies.Any());
        }
    }
}