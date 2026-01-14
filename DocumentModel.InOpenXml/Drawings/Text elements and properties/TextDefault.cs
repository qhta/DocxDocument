namespace DocumentModel.Drawings;

/// <summary>
///   Represents default text properties for a shape, including shape, body, list, and style settings.
/// </summary>
public interface TextDefault : IExtendableElement
{
  /// <summary>
  ///   Default shape properties for text.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Default body properties for text.
  /// </summary>
  public BodyProperties? BodyProperties { get; set; }

  /// <summary>
  ///   Default list style for text.
  /// </summary>
  public ListStyle? ListStyle { get; set; }

  /// <summary>
  ///   Default shape style for text.
  /// </summary>
  public ShapeStyle? ShapeStyle { get; set; }
}