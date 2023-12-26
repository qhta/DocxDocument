namespace DocumentModel.Drawings;


/// <summary>
///   Line Spacing.
/// </summary>
public partial class LineSpacing: ModelElement<DXD.LineSpacing>
{
  public LineSpacing(): base(){ }
  
  public LineSpacing(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineSpacing(DXD.LineSpacing openXmlElement): base(openXmlElement) { }
  
}
