namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CategoryFilterException Class.
/// </summary>
public class CategoryFilterException: ModelElement
{
  /// <summary>
  ///   SequenceOfReferences.
  /// </summary>
  public String? SequenceOfReferences { get; set; }

  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public ShapeProperties3? ShapeProperties { get; set; }

  /// <summary>
  ///   Explosion.
  /// </summary>
  public UInt32? Explosion { get; set; }

  /// <summary>
  ///   InvertIfNegativeBoolean.
  /// </summary>
  public Boolean? InvertIfNegativeBoolean { get; set; }

  /// <summary>
  ///   Bubble3D.
  /// </summary>
  public Boolean? Bubble3D { get; set; }

  /// <summary>
  ///   Marker.
  /// </summary>
  public Marker3? Marker { get; set; }

  /// <summary>
  ///   DataLabel.
  /// </summary>
  public DataLabel3? DataLabel { get; set; }
}