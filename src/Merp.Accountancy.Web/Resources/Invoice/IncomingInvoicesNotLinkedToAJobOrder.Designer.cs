﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Merp.Accountancy.Web.Resources.Invoice {
    using System;
    
    
    /// <summary>
    ///   Classe di risorse fortemente tipizzata per la ricerca di stringhe localizzate e così via.
    /// </summary>
    // Questa classe è stata generata automaticamente dalla classe StronglyTypedResourceBuilder.
    // tramite uno strumento quale ResGen o Visual Studio.
    // Per aggiungere o rimuovere un membro, modificare il file con estensione ResX ed eseguire nuovamente ResGen
    // con l'opzione /str oppure ricompilare il progetto VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class IncomingInvoicesNotLinkedToAJobOrder {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal IncomingInvoicesNotLinkedToAJobOrder() {
        }
        
        /// <summary>
        ///   Restituisce l'istanza di ResourceManager nella cache utilizzata da questa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Merp.Accountancy.Web.Resources.Invoice.IncomingInvoicesNotLinkedToAJobOrder", typeof(IncomingInvoicesNotLinkedToAJobOrder).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Esegue l'override della proprietà CurrentUICulture del thread corrente per tutte le
        ///   ricerche di risorse eseguite utilizzando questa classe di risorse fortemente tipizzata.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Cerca una stringa localizzata simile a Date of link.
        /// </summary>
        internal static string DateOfLink {
            get {
                return ResourceManager.GetString("DateOfLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Cerca una stringa localizzata simile a Document type.
        /// </summary>
        internal static string DocumentType {
            get {
                return ResourceManager.GetString("DocumentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Cerca una stringa localizzata simile a Incoming invoices not linked to a job order.
        /// </summary>
        internal static string IncomingInvoicesNotLinkedToAJobOrderPageTitle {
            get {
                return ResourceManager.GetString("IncomingInvoicesNotLinkedToAJobOrderPageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Cerca una stringa localizzata simile a Job order number.
        /// </summary>
        internal static string JobOrderNumber {
            get {
                return ResourceManager.GetString("JobOrderNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Cerca una stringa localizzata simile a Link invoice to job order.
        /// </summary>
        internal static string LinkInvoiceToJobOrder {
            get {
                return ResourceManager.GetString("LinkInvoiceToJobOrder", resourceCulture);
            }
        }
    }
}
