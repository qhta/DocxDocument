namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SurfaceType Class.
/// </summary>
public class SurfaceType: ModelElement
{
  /// <summary>
  ///   Thickness.
  /// </summary>
  public Byte? Thickness { get; set; }

  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Picture Options.
  /// </summary>
  public PictureOptions? PictureOptions { get; set; }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}