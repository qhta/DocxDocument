namespace DocumentModel.Drawings.Charts;

/// <summary>
///   3D floor formatting.
/// </summary>
public class Floor: ModelElement
{
  public Byte? Thickness { get; set; }

  public ShapeProperties? ShapeProperties { get; set; }

  public PictureOptions? PictureOptions { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}