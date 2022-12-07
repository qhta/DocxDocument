namespace DocumentModel.Drawings;

/// <summary>
/// 3D back wall formatting.
/// </summary>
public class BackWallImpl: DocumentModel.Drawings.SurfaceTypeImpl, BackWall
{
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
