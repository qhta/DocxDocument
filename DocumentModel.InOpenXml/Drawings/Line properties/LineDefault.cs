namespace DocumentModel.Drawings;

/// <summary>
///   Represents default line properties, including shape, body, list, and style settings.
/// </summary>
public interface LineDefault : IExtendableElement
{
  /// <summary>
  ///   Default shape properties for the line.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Default body properties for the line.
  /// </summary>
  public BodyProperties? BodyProperties { get; set; }

  /// <summary>
  ///   Default list style for the line.
  /// </summary>
  public ListStyle? ListStyle { get; set; }

  /// <summary>
  ///   Default shape style for the line.
  /// </summary>
  public ShapeStyle? ShapeStyle { get; set; }
}