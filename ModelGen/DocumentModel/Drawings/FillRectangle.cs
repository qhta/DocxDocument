namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a fill rectangle. When stretching of an image is specified, a source rectangle, srcRect, is scaled to fit the specified fill rectangle.
/// </summary>
public partial class FillRectangle: ModelElement<DXD.FillRectangle>
{
  public FillRectangle(): base(){ }
  
  public FillRectangle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FillRectangle(DXD.FillRectangle openXmlElement): base(openXmlElement) { }
  
}
