namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Format ID.
/// </summary>
public partial class FormatId: ModelElement<DXDC.FormatId>
{
  public FormatId(): base(){ }
  
  public FormatId(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FormatId(DXDC.FormatId openXmlElement): base(openXmlElement) { }
  
}
