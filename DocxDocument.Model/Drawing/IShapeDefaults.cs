using DocumentFormat.OpenXml;

namespace DocxDocument.Model;

public interface IShapeDefaults
{
  /// <summary>
  /// <para>VML Extension Handling Behavior</para>
  /// </summary>
  public ExtensionHandlingBehavior? Extension{ get; set; }

  /// <summary>
  /// <para>Shape ID Optional Storage</para>
  /// </summary>
  public long? MaxShapeId{ get; set; }

  /// <summary>
  /// <para>style</para>
  /// </summary>
  public String? Style{ get; set; }

  /// <summary>
  /// <para>Shape Fill Toggle</para>
  /// </summary>
  public bool? BeFilled{ get; set; }

  /// <summary>
  /// <para>Default Fill Color</para>
  /// </summary>
  public String? FillColor{ get; set; }

  /// <summary>
  /// <para>Shape Stroke Toggle</para>
  /// </summary>
  public bool? IsStroke{ get; set; }

  /// <summary>
  /// <para>Shape Stroke Color</para>
  /// </summary>
  public String? StrokeColor{ get; set; }

  /// <summary>
  /// <para>Allow in Table Cell</para>
  /// </summary>
  public bool? AllowInCell{ get; set; }

  /// <summary>
  /// <para>allowoverlap</para>
  /// </summary>
  public bool? AllowOverlap{ get; set; }

  /// <summary>
  /// <para>insetmode</para>
  /// </summary>
  public InsetMode? InsetMode{ get; set; }


}