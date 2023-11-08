namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TemporarySdt Class.
/// </summary>
public partial class TemporarySdt: ModelElement<DXW.TemporarySdt>
{
  public TemporarySdt(): base(){ }
  
  public TemporarySdt(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TemporarySdt(DXW.TemporarySdt openXmlElement): base(openXmlElement) { }
  
}
