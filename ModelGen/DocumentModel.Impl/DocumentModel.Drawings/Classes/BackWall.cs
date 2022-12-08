namespace DocumentModel.Drawings;

/// <summary>
/// 3D back wall formatting.
/// </summary>
public class BackWallImpl: DocumentModel.Drawings.SurfaceTypeImpl, BackWall
{
  public new DocumentFormat.OpenXml.Drawing.Charts.BackWall? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BackWall?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override Byte? Thickness
  {
    get;
    set;
  }
  
  public override ShapeProperties1? ShapeProperties
  {
    get;
    set;
  }
  
  public override PictureOptions? PictureOptions
  {
    get;
    set;
  }
  
  public override ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
