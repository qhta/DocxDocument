namespace DocumentModel.Drawings;

/// <summary>
///   Defines the Blur Class.
/// </summary>
public record Blur
{
  /// <summary>
  ///   Radius
  /// </summary>
  public Int64? Radius { get; set; }

  /// <summary>
  ///   Grow Bounds
  /// </summary>
  public Boolean? Grow { get; set; }
}