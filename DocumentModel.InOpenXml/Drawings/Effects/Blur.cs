namespace DocumentModel.Drawings;

/// <summary>
/// Represents a blur effect, allowing the application of a blur with a specified radius and optional bounds growth.
/// </summary>
public class Blur: ModelElement
{
  /// <summary>
  /// Radius of the blur effect.
  /// </summary>
  public Int64? Radius { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the bounds should grow to accommodate the blur.
  /// </summary>
  public bool? Grow { get; set; }
}