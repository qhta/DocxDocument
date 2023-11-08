namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the portion of the blip used for the fill.
/// </summary>
public partial class SourceRectangle: ModelElement<DXD.SourceRectangle>
{
  public SourceRectangle(): base(){ }
  
  public SourceRectangle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SourceRectangle(DXD.SourceRectangle openXmlElement): base(openXmlElement) { }
  
}
