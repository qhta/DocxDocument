namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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