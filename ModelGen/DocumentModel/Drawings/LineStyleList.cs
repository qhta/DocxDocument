namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a list of three line styles for use within a theme.  The three line styles are arranged in order from subtle to moderate to intense versions of lines.  This list makes up part of the style matrix.
/// </summary>
public partial class LineStyleList: ModelElement<DXD.LineStyleList>
{
  public LineStyleList(): base(){ }
  
  public LineStyleList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineStyleList(DXD.LineStyleList openXmlElement): base(openXmlElement) { }
  
}
