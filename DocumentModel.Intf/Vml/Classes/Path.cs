namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Path Class.
/// </summary>
public class Path: ModelElement
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Path Definition
  /// </summary>
  public string? Value { get; set; }

  /// <summary>
  ///   Limo Stretch Point
  /// </summary>
  public string? Limo { get; set; }

  /// <summary>
  ///   Text Box Bounding Box
  /// </summary>
  public string? TextboxRectangle { get; set; }

  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  public bool? AllowFill { get; set; }

  /// <summary>
  ///   Stroke Toggle
  /// </summary>
  public bool? AllowStroke { get; set; }

  /// <summary>
  ///   Shadow Toggle
  /// </summary>
  public bool? AllowShading { get; set; }

  /// <summary>
  ///   Arrowhead Display Toggle
  /// </summary>
  public bool? ShowArrowhead { get; set; }

  /// <summary>
  ///   Gradient Shape Toggle
  /// </summary>
  public bool? AllowGradientShape { get; set; }

  /// <summary>
  ///   Text Path Toggle
  /// </summary>
  public bool? AllowTextPath { get; set; }

  /// <summary>
  ///   Inset Stroke From Path Flag
  /// </summary>
  public bool? AllowInsetPen { get; set; }

  /// <summary>
  ///   Connection Point Type
  /// </summary>
  public ConnectKind? ConnectionPointType { get; set; }

  /// <summary>
  ///   Connection Points
  /// </summary>
  public string? ConnectionPoints { get; set; }

  /// <summary>
  ///   Connection Point Connect Angles
  /// </summary>
  public string? ConnectAngles { get; set; }

  /// <summary>
  ///   Extrusion Toggle
  /// </summary>
  public bool? AllowExtrusion { get; set; }
}