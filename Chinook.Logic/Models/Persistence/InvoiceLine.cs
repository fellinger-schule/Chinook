using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Logic.Models.Persistence
{
	[CsvMapper.Logic.Attributes.DataClass(HasHeader = true, FileName = "CsvData/InvoiceLine.csv")]
	internal class InvoiceLine : IdentityObject, Contracts.Persistence.IInvoiceLine
	{
		[CsvMapper.Logic.Attributes.DataPropertyInfo(OrderPosition = 1)]
        public int InvoiceId { get; set; }
        [CsvMapper.Logic.Attributes.DataPropertyInfo(OrderPosition = 2)]
        public int TrackId { get; set; }
        [CsvMapper.Logic.Attributes.DataPropertyInfo(OrderPosition = 3)]
        public float UnitPrice { get; set; }
        [CsvMapper.Logic.Attributes.DataPropertyInfo(OrderPosition = 4)]
        public int Quantity { get; set; }
    }
}
