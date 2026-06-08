namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Draw Arc To.
/// </summary>
public class ArcTo: ModelElement
{
  /// <summary>
  ///   IShape Arc Width Radius
  /// </summary>
  public string? WidthRadius { get; set; }

  /// <summary>
  ///   IShape Arc Height Radius
  /// </summary>
  public string? HeightRadius { get; set; }

  /// <summary>
  ///   IShape Arc Start Angle
  /// </summary>
  public string? StartAngle { get; set; }

  /// <summary>
  ///   IShape Arc Swing Angle
  /// </summary>
  public string? SwingAngle { get; set; }
}
