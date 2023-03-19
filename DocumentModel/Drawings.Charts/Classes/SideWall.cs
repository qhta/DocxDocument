namespace DocumentModel.Drawings.Charts;

/// <summary>
///   3D side wall formatting.
/// </summary>
public class SideWall: ModelElement
{
  public Byte? Thickness { get; set; }

  public ShapeProperties? ShapeProperties { get; set; }

  public PictureOptions? PictureOptions { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}