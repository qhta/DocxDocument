namespace DocumentModel.Vml;


/// <summary>
///   Defines the Fill Class.
/// </summary>
public partial class Fill
{
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Fill Toggle
  /// </summary>
  public DM.TrueFalseValue? On { get; set; }
  
  
  /// <summary>
  ///   Primary Color
  /// </summary>
  public String? Color { get; set; }
  
  
  /// <summary>
  ///   Primary Color Opacity
  /// </summary>
  public String? Opacity { get; set; }
  
  
  /// <summary>
  ///   Secondary Color
  /// </summary>
  public String? Color2 { get; set; }
  
  
  /// <summary>
  ///   Fill Image Source
  /// </summary>
  public String? Source { get; set; }
  
  
  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  public String? Href { get; set; }
  
  
  /// <summary>
  ///   Alternate Image Reference Location
  /// </summary>
  public String? AlternateImageReference { get; set; }
  
  
  /// <summary>
  ///   Fill Image Size
  /// </summary>
  public String? Size { get; set; }
  
  
  /// <summary>
  ///   Fill Image Origin
  /// </summary>
  public String? Origin { get; set; }
  
  
  /// <summary>
  ///   Fill Image Position
  /// </summary>
  public String? Position { get; set; }
  
  
  /// <summary>
  ///   Intermediate Colors
  /// </summary>
  public String? Colors { get; set; }
  
  
  /// <summary>
  ///   Gradient Angle
  /// </summary>
  public Decimal? Angle { get; set; }
  
  
  /// <summary>
  ///   Align Image With Shape
  /// </summary>
  public DM.TrueFalseValue? AlignShape { get; set; }
  
  
  /// <summary>
  ///   Gradient Center
  /// </summary>
  public String? Focus { get; set; }
  
  
  /// <summary>
  ///   Radial Gradient Size
  /// </summary>
  public String? FocusSize { get; set; }
  
  
  /// <summary>
  ///   Radial Gradient Center
  /// </summary>
  public String? FocusPosition { get; set; }
  
  
  /// <summary>
  ///   Detect Mouse Click
  /// </summary>
  public DM.TrueFalseValue? DetectMouseClick { get; set; }
  
  
  /// <summary>
  ///   Title
  /// </summary>
  public String? Title { get; set; }
  
  
  /// <summary>
  ///   Secondary Color Opacity
  /// </summary>
  public String? Opacity2 { get; set; }
  
  
  /// <summary>
  ///   Recolor Fill as Picture
  /// </summary>
  public DM.TrueFalseValue? Recolor { get; set; }
  
  
  /// <summary>
  ///   Rotate Fill with Shape
  /// </summary>
  public DM.TrueFalseValue? Rotate { get; set; }
  
  
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  public String? RelationshipId { get; set; }
  
  
  /// <summary>
  ///   FillExtendedProperties.
  /// </summary>
  public DocumentModel.Vml.Office.FillExtendedProperties? FillExtendedProperties { get; set; }
  
}
