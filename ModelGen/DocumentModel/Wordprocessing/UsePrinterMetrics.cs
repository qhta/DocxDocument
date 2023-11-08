namespace DocumentModel.Wordprocessing;


/// <summary>
///   Use Printer Metrics To Display Documents.
/// </summary>
public partial class UsePrinterMetrics: ModelElement<DXW.UsePrinterMetrics>
{
  public UsePrinterMetrics(): base(){ }
  
  public UsePrinterMetrics(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UsePrinterMetrics(DXW.UsePrinterMetrics openXmlElement): base(openXmlElement) { }
  
}
