namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the ending of a series of lines and curves in the creation path of a custom geometric shape. When this element is encountered, the generating application should consider the corresponding path closed. That is, any further lines or curves that follow this element should be ignored.
/// </summary>
public partial class CloseShapePath: ModelElement<DXD.CloseShapePath>
{
  public CloseShapePath(): base(){ }
  
  public CloseShapePath(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CloseShapePath(DXD.CloseShapePath openXmlElement): base(openXmlElement) { }
  
}
