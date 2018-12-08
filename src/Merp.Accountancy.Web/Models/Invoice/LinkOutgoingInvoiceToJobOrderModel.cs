﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Merp.Accountancy.Web.Models.Invoice
{
    public class LinkOutgoingInvoiceToJobOrderModel
    {
        public decimal Amount { get; set; }

        [Required]
        public DateTime DateOfLink { get; set; }

        [Required]
        public string JobOrderNumber { get; set; }

        public OutgoingDocumentTypes Type { get; set; }
    }
}
