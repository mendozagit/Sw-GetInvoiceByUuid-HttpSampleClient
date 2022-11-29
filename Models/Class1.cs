using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SW_APIS_CLIENT.Models
{
    public class StorageResponse 
    {
        public string status { get; set; }
        public string message { get; set; }
        public string messageDetail { get; set; }

        public Data data { get; set; }
    }
    public partial class Data
    {
        
        public MetaData metaData { get; set; }
        
        public List<Records> records { get; set; }
    }
    public partial class Records
    {
        
        public string status { get; set; }

        
        public string urlPdf { get; set; }
        
        public string urlXml { get; set; }
        
        public bool hasAddenda { get; set; }
        
        public object addenda { get; set; }
        
        public string idDealer { get; set; }
        
        public string idUser { get; set; }
        
        public string version { get; set; }
        
        public string serie { get; set; }
        
        public string folio { get; set; }
        
        public DateTime fecha { get; set; }
        
        public string numeroCertificado { get; set; }
        
        public double subtotal { get; set; }
        
        public double descuento { get; set; }
        
        public double total { get; set; }
        
        public string moneda { get; set; }
        
        public double tipoCambio { get; set; }
        
        public string tipoDeComprobante { get; set; }
        
        public string metodoPago { get; set; }
        
        public string formaPago { get; set; }
        
        public string condicionesPago { get; set; }
        
        public string luegarExpedicion { get; set; }
        
        public string rfcEmisor { get; set; }
        
        public string nombreEmisor { get; set; }
        
        public string regimenFiscal { get; set; }
        
        public string rfcReceptor { get; set; }
        
        public string nombreReceptor { get; set; }
        
        public string residenciaFiscal { get; set; }
        
        public string numRegIdTrib { get; set; }
        
        public string usoCFDI { get; set; }
        
        public double totalImpuestosTraslados { get; set; }
        
        public double totalImpuestosRetencion { get; set; }
        
        public double trasladosIVA { get; set; }
        
        public double trasladosIEPS { get; set; }
        
        public double retencionesISR { get; set; }
        
        public double retencionesIVA { get; set; }
        
        public double retencionesIEPS { get; set; }
        
        public double totalImpuestosLocalesTraslados { get; set; }
        
        public double totalImpuestosLocalesRetencion { get; set; }
        
        public string complementos { get; set; }
        
        public string uuid { get; set; }
        
        public DateTime fechaTimbrado { get; set; }
        
        public string rfcProvCertif { get; set; }
        
        public string selloCFD { get; set; }
        
        public string urlAckCfdi { get; set; }
        
        public string urlAckCancellation { get; set; }
        
        public string urlAddenda { get; set; }
        
        public DateTime? fechaGeneracionPdf { get; set; }
        
        public string emisorRfc { get; set; }
        
        public string emisorNombre { get; set; }
        
        public string receptorRfc { get; set; }
        
        public string receptorNombre { get; set; }

    }
    public partial class MetaData
    {
        
        public string page { get; set; }
        
        public string perPage { get; set; }
        
        public string pageCount { get; set; }
        
        public string totalCount { get; set; }
        
        public Links links { get; set; }
    }
    public partial class Links
    {
        public string current { get; set; }
    }
}
