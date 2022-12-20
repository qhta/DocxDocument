namespace DocxDocument.Model;

public class ShapeDefaults: DocxBasedElement<VO.ShapeDefaults>, IShapeDefaults
{
  public ShapeDefaults() : base(new VO.ShapeDefaults())
  {
  }

  public ShapeDefaults(VO.ShapeDefaults element) : base(element)
  {
  }

  /// <summary>
  /// <para>VML Extension Handling Behavior</para>
  /// </summary>
  public ExtensionHandlingBehavior? Extension
  {
    get => (ExtensionHandlingBehavior?)DocxElement.Extension?.Value;
    set => DocxElement.Extension = (value != null) ? (V.ExtensionHandlingBehaviorValues)value : null;
  }

  /// <summary>
  /// <para>Shape ID Optional Storage</para>
  /// </summary>
  public long? MaxShapeId
  {
    get => DocxElement.MaxShapeId?.Value;
    set => DocxElement.MaxShapeId = (value != null) ? (long)value : null;
  }

  /// <summary>
  /// <para>style</para>
  /// </summary>
  public String? Style
  {
    get => DocxElement.Style?.Value; 
    set => DocxElement.Style = (value != null) ? (string)value : null;
  }

  /// <summary>
  /// <para>Shape Fill Toggle</para>
  /// </summary>
  public bool? BeFilled
  {
    get => DocxElement.BeFilled?.Value;
    set => DocxElement.BeFilled = (value != null) ? (bool)value : null;
  }

  /// <summary>
  /// <para>Default Fill Color</para>
  /// </summary>
  public String? FillColor
  {
    get => DocxElement.FillColor?.Value;
    set => DocxElement.FillColor = (value != null) ? (string)value : null;
  }

  /// <summary>
  /// <para>Shape Stroke Toggle</para>
  /// </summary>
  public bool? IsStroke
  {
    get => DocxElement.IsStroke?.Value;
    set => DocxElement.IsStroke = (value != null) ? (bool)value : null;
  }

  /// <summary>
  /// <para>Shape Stroke Color</para>
  /// </summary>
  public String? StrokeColor
  {
    get => DocxElement.StrokeColor?.Value;
    set => DocxElement.StrokeColor = (value != null) ? (string)value : null;
  }

  /// <summary>
  /// <para>Allow in Table Cell</para>
  /// </summary>
  public bool? AllowInCell
  {
    get => DocxElement.AllowInCell?.Value;
    set => DocxElement.AllowInCell = (value != null) ? (bool)value : null;
  }

  /// <summary>
  /// <para>allowoverlap</para>
  /// </summary>
  public bool? AllowOverlap
  {
    get => DocxElement.AllowOverlap?.Value;
    set => DocxElement.AllowOverlap = (value != null) ? (bool)value : null;
  }

  /// <summary>
  /// <para>insetmode</para>
  /// </summary>
  public InsetMode? InsetMode
  {
    get => (InsetMode?)DocxElement.InsetMode?.Value;
    set => DocxElement.InsetMode = (value != null) ? (VO.InsetMarginValues)value : null;
  }

}