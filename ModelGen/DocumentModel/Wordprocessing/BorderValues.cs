namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the BorderValues enumeration.
/// </summary>
public partial class BorderValues: ModelElement<DXW.BorderValues>
{
  public BorderValues(): base(){ }
  
  public BorderValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BorderValues(DXW.BorderValues openXmlElement): base(openXmlElement) { }
  
}
