namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Wrapping Polygon Line End Position.
/// </summary>
public partial class LineTo: ModelElement<DXDW.LineTo>
{
  public LineTo(): base(){ }
  
  public LineTo(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineTo(DXDW.LineTo openXmlElement): base(openXmlElement) { }
  
}
