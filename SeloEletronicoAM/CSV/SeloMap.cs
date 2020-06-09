using CsvHelper.Configuration;
using SeloEletronicoAM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeloEletronicoAM.CSV
{
    public class SeloMap : ClassMap<Selo>
    {
        public SeloMap()
        {
            Map(m => m.Codigo).Index(0);
            Map(m => m.AtoTabela.Emolumento).Index(1);
            Map(m => m.AtoTabela.Funetj).Index(2);
            Map(m => m.AtoTabela.Fundpam).Index(3);
            Map(m => m.AtoTabela.Fundpge).Index(4);
            Map(m => m.AtoTabela.Farpam).Index(5);
            Map(m => m.InfoIsento.Isento).Index(6);
            //.TypeConverterOption.BooleanValues(true, true, "1", "Y")
            //.TypeConverterOption.BooleanValues(false, false, "0", "N");
        }
    }
}
