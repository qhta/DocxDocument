namespace DocumentModel.Drawings;


/// <summary>
///   End Line Cap
/// </summary>
public partial class LineCapValues: ModelElement<DXD.LineCapValues>
{
  public LineCapValues(): base(){ }
  
  public LineCapValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineCapValues(DXD.LineCapValues openXmlElement): base(openXmlElement) { }
  
}
