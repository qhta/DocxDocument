namespace DocumentModel.Drawings;

/// <summary>
///   Graphic Object.
/// </summary>
public record Graphic
{
  /// <summary>
  ///   Graphic Object Data.
  /// </summary>
  public GraphicData? GraphicData { get; set; }
}