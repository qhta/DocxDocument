namespace DocumentModel.Drawings;

/// <summary>
///   Represents default formatting properties for objects in a theme, including shape, line, and text defaults.
/// </summary>
public interface ObjectDefaults : IExtendableElement
{
  /// <summary>
  ///   Default formatting properties for shapes.
  /// </summary>
  public ShapeDefault? ShapeDefault { get; set; }

  /// <summary>
  ///   Default formatting properties for lines.
  /// </summary>
  public LineDefault? LineDefault { get; set; }

  /// <summary>
  ///   Default formatting properties for text.
  /// </summary>
  public TextDefault? TextDefault { get; set; }
}