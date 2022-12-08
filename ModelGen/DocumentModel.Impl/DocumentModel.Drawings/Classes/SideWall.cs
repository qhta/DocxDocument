namespace DocumentModel.Drawings;

/// <summary>
/// 3D side wall formatting.
/// </summary>
public class SideWallImpl: DocumentModel.Drawings.SurfaceTypeImpl, SideWall
{
  public new DocumentFormat.OpenXml.Drawing.Charts.SideWall? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SideWall?)_OpenXmlElement;
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
