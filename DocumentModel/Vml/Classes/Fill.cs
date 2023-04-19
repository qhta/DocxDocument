namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Fill Class.
/// </summary>
public class Fill: ModelElement
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Fill Type
  /// </summary>
  public FillKind? Type { get; set; }

  /// <summary>
  ///   Fill Toggle
  /// </summary>
  public bool? On { get; set; }

  /// <summary>
  ///   Primary Color
  /// </summary>
  public string? Color { get; set; }

  /// <summary>
  ///   Primary Color Opacity
  /// </summary>
  public string? Opacity { get; set; }

  /// <summary>
  ///   Secondary Color
  /// </summary>
  public string? Color2 { get; set; }

  /// <summary>
  ///   Fill Image Source
  /// </summary>
  public string? Source { get; set; }

  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  public string? Href { get; set; }

  /// <summary>
  ///   Alternate Image Reference Location
  /// </summary>
  public string? AlternateImageReference { get; set; }

  /// <summary>
  ///   Fill Image Size
  /// </summary>
  public string? Size { get; set; }

  /// <summary>
  ///   Fill Image Origin
  /// </summary>
  public string? Origin { get; set; }

  /// <summary>
  ///   Fill Image Position
  /// </summary>
  public string? Position { get; set; }

  /// <summary>
  ///   Image Aspect Ratio
  /// </summary>
  public ImageAspectKind? Aspect { get; set; }

  /// <summary>
  ///   Intermediate Colors
  /// </summary>
  public string? Colors { get; set; }

  /// <summary>
  ///   Gradient Angle
  /// </summary>
  public Decimal? Angle { get; set; }

  /// <summary>
  ///   Align Image With Shape
  /// </summary>
  public bool? AlignShape { get; set; }

  /// <summary>
  ///   Gradient Center
  /// </summary>
  public string? Focus { get; set; }

  /// <summary>
  ///   Radial Gradient Size
  /// </summary>
  public string? FocusSize { get; set; }

  /// <summary>
  ///   Radial Gradient Center
  /// </summary>
  public string? FocusPosition { get; set; }

  /// <summary>
  ///   Gradient Fill Method
  /// </summary>
  public FillMethodKind? Method { get; set; }

  /// <summary>
  ///   Detect Mouse Click
  /// </summary>
  public bool? DetectMouseClick { get; set; }

  /// <summary>
  ///   Title
  /// </summary>
  public string? Title { get; set; }

  /// <summary>
  ///   Secondary Color Opacity
  /// </summary>
  public string? Opacity2 { get; set; }

  /// <summary>
  ///   Recolor Fill as Picture
  /// </summary>
  public bool? Recolor { get; set; }

  /// <summary>
  ///   Rotate Fill with Shape
  /// </summary>
  public bool? Rotate { get; set; }

  /// <summary>
  ///   Relationship to Part
  /// </summary>
  public string? RelationshipId { get; set; }

  /// <summary>
  ///   FillExtendedProperties.
  /// </summary>
  public FillExtendedProperties? FillExtendedProperties { get; set; }
}