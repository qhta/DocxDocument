namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an exception to a category filter in a chart, including references, shape properties, explosion, inversion, 3D bubble option, marker, and data label.
/// </summary>
public interface CategoryFilterException : CollectionItem
{
  /// <summary>
  ///   Sequence of references associated with the category filter exception.
  /// </summary>
  public string? SequenceOfReferences { get; set; }

  /// <summary>
  ///   Shape properties for the exception.
  /// </summary>
  public ShapeProperties3? ShapeProperties { get; set; }

  /// <summary>
  ///   Explosion value indicating how far a slice is pulled from the chart.
  /// </summary>
  public UInt32? Explosion { get; set; }

  /// <summary>
  ///   Indicates whether to invert colors if the value is negative.
  /// </summary>
  public bool? InvertIfNegativeBoolean { get; set; }

  /// <summary>
  ///   Indicates whether bubbles are rendered in 3D.
  /// </summary>
  public bool? Bubble3D { get; set; }

  /// <summary>
  ///   Marker configuration for the exception.
  /// </summary>
  public Marker3? Marker { get; set; }

  /// <summary>
  ///   Data label configuration for the exception.
  /// </summary>
  public DataLabel3? DataLabel { get; set; }
}