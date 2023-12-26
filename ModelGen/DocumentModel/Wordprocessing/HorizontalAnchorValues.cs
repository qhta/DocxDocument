namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the HorizontalAnchorValues enumeration.
/// </summary>
public partial class HorizontalAnchorValues: ModelElement<DXW.HorizontalAnchorValues>
{
  public HorizontalAnchorValues(): base(){ }
  
  public HorizontalAnchorValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HorizontalAnchorValues(DXW.HorizontalAnchorValues openXmlElement): base(openXmlElement) { }
  
}
