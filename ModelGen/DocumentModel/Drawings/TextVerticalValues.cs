namespace DocumentModel.Drawings;


/// <summary>
///   Vertical Text Types
/// </summary>
public partial class TextVerticalValues: ModelElement<DXD.TextVerticalValues>
{
  public TextVerticalValues(): base(){ }
  
  public TextVerticalValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextVerticalValues(DXD.TextVerticalValues openXmlElement): base(openXmlElement) { }
  
}
