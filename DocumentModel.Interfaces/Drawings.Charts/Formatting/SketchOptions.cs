namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the SketchOptions Class.
/// </summary>
public interface SketchOptions
{
  /// <summary>
  ///   InSketchMode.
  /// </summary>
  public bool? InSketchMode { get; set; }
  /// <summary>
  ///   ShowSketchButton.
  /// </summary>
  public bool? ShowSketchButton { get; set; }
}