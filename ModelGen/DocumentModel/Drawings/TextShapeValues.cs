namespace DocumentModel.Drawings;


/// <summary>
///   Preset Text Shape Types
/// </summary>
public partial class TextShapeValues: ModelElement<DXD.TextShapeValues>
{
  public TextShapeValues(): base(){ }
  
  public TextShapeValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextShapeValues(DXD.TextShapeValues openXmlElement): base(openXmlElement) { }
  
}
