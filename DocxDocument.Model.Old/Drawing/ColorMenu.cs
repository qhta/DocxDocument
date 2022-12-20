using DocumentFormat.OpenXml.Vml.Office;
using DocumentFormat.OpenXml;

namespace DocxDocument.Model;

public class ColorMenu: DocxBasedElement<VO.ColorMenu>, IColorMenu
{

  public ColorMenu(VO.ColorMenu element) : base(element)
  {
  }

  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehavior? Extension
  {
    get => (ExtensionHandlingBehavior?)DocxElement.Extension?.Value;
    set => DocxElement.Extension = (value != null) ? (V.ExtensionHandlingBehaviorValues)value : null;
  }

  /// <summary>
  /// Default stroke color
  /// </summary>
  public String? StrokeColor
  {
    get => DocxElement.StrokeColor?.Value;
    set => DocxElement.StrokeColor = (value != null) ? (string)value : null;
  }

  /// <summary>
  /// Default fill color
  /// Represents the following attribute in the schema: fillcolor
  /// </summary>
  public String? FillColor
  {
    get => DocxElement.FillColor?.Value;
    set => DocxElement.FillColor = (value != null) ? (string)value : null;
  }

  /// <summary>
  /// Default shadow color
  /// Represents the following attribute in the schema: shadowcolor
  /// </summary>
  public String? ShadowColor
  {
    get => DocxElement.ShadowColor?.Value;
    set => DocxElement.ShadowColor = (value != null) ? (string)value : null;
  }

  /// <summary>
  /// Default extrusion color
  /// Represents the following attribute in the schema: extrusioncolor
  /// </summary>
  public String? ExtrusionColor
  {
    get => DocxElement.ExtrusionColor?.Value;
    set => DocxElement.ExtrusionColor = (value != null) ? (string)value : null;
  }

}