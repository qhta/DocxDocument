namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   UI Default Colors.
/// </summary>
public class ColorMenu: ModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }

  /// <summary>
  ///   Default stroke color
  /// </summary>
  public string? StrokeColor { get; set; }

  /// <summary>
  ///   Default fill color
  /// </summary>
  public string? FillColor { get; set; }

  /// <summary>
  ///   Default shadow color
  /// </summary>
  public string? ShadowColor { get; set; }

  /// <summary>
  ///   Default extrusion color
  /// </summary>
  public string? ExtrusionColor { get; set; }
}