namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SketchOptions Class.
/// </summary>
public class SketchOptions: ModelElement
{
  /// <summary>
  ///   InSketchMode.
  /// </summary>
  public Boolean? InSketchMode { get; set; }

  /// <summary>
  ///   ShowSketchButton.
  /// </summary>
  public Boolean? ShowSketchButton { get; set; }
}