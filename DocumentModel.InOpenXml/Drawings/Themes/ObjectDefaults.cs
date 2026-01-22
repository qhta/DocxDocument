namespace DocumentModel.Drawings;

/// <summary>
///   Represents default formatting properties for objects in a theme, including shape, line, and text defaults.
/// </summary>
public class ObjectDefaults : ModelElement<DXD.ObjectDefaults>, IExtendableElement
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

  /// <summary>
  /// List of extensions for future extensions of the element type.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}