namespace DocxDocument.Model;

public interface IColorMenu
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehavior? Extension { get; set; }

  /// <summary>
  /// Default stroke color
  /// </summary>
  public String? StrokeColor { get; set; }

  /// <summary>
  /// Default fill color
  /// Represents the following attribute in the schema: fillcolor
  /// </summary>
  public String? FillColor { get; set; }

  /// <summary>
  /// Default shadow color
  /// Represents the following attribute in the schema: shadowcolor
  /// </summary>
  public String? ShadowColor { get; set; }

  /// <summary>
  /// Default extrusion color
  /// Represents the following attribute in the schema: extrusioncolor
  /// </summary>
  public String? ExtrusionColor { get; set; }

}