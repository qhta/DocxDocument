namespace DocumentModel.Drawings.Charts;

/// <summary>
///   3D back wall formatting.
/// </summary>
public class BackWall: ModelElement
{
  public Byte? Thickness { get; set; }

  public ShapeProperties? ShapeProperties { get; set; }

  public PictureOptions? PictureOptions { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}