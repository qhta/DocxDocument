namespace DocumentModel.Drawings;

/// <summary>
/// 3D floor formatting.
/// </summary>
public class Floor1Impl: DocumentModel.Drawings.SurfaceTypeImpl, Floor1
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
