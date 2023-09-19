namespace DocumentModel.Vml;


/// <summary>
///   Defines the Fill Class.
/// </summary>
public partial class Fill
{
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [SchemaAttr("id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Fill Type
  /// </summary>
  [SchemaAttr("type")]
  public DocumentModel.Vml.FillTypeValues? Type { get; set; }
  
  
  /// <summary>
  ///   Fill Toggle
  /// </summary>
  [SchemaAttr("on")]
  public Boolean? On { get; set; }
  
  
  /// <summary>
  ///   Primary Color
  /// </summary>
  [SchemaAttr("color")]
  public String? Color { get; set; }
  
  
  /// <summary>
  ///   Primary Color Opacity
  /// </summary>
  [SchemaAttr("opacity")]
  public String? Opacity { get; set; }
  
  
  /// <summary>
  ///   Secondary Color
  /// </summary>
  [SchemaAttr("color2")]
  public String? Color2 { get; set; }
  
  
  /// <summary>
  ///   Fill Image Source
  /// </summary>
  [SchemaAttr("src")]
  public String? Source { get; set; }
  
  
  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  [SchemaAttr("o:href")]
  public String? Href { get; set; }
  
  
  /// <summary>
  ///   Alternate Image Reference Location
  /// </summary>
  [SchemaAttr("o:althref")]
  public String? AlternateImageReference { get; set; }
  
  
  /// <summary>
  ///   Fill Image Size
  /// </summary>
  [SchemaAttr("size")]
  public String? Size { get; set; }
  
  
  /// <summary>
  ///   Fill Image Origin
  /// </summary>
  [SchemaAttr("origin")]
  public String? Origin { get; set; }
  
  
  /// <summary>
  ///   Fill Image Position
  /// </summary>
  [SchemaAttr("position")]
  public String? Position { get; set; }
  
  
  /// <summary>
  ///   Image Aspect Ratio
  /// </summary>
  [SchemaAttr("aspect")]
  public DocumentModel.Vml.ImageAspectValues? Aspect { get; set; }
  
  
  /// <summary>
  ///   Intermediate Colors
  /// </summary>
  [SchemaAttr("colors")]
  public String? Colors { get; set; }
  
  
  /// <summary>
  ///   Gradient Angle
  /// </summary>
  [SchemaAttr("angle")]
  public Decimal? Angle { get; set; }
  
  
  /// <summary>
  ///   Align Image With Shape
  /// </summary>
  [SchemaAttr("alignshape")]
  public Boolean? AlignShape { get; set; }
  
  
  /// <summary>
  ///   Gradient Center
  /// </summary>
  [SchemaAttr("focus")]
  public String? Focus { get; set; }
  
  
  /// <summary>
  ///   Radial Gradient Size
  /// </summary>
  [SchemaAttr("focussize")]
  public String? FocusSize { get; set; }
  
  
  /// <summary>
  ///   Radial Gradient Center
  /// </summary>
  [SchemaAttr("focusposition")]
  public String? FocusPosition { get; set; }
  
  
  /// <summary>
  ///   Gradient Fill Method
  /// </summary>
  [SchemaAttr("method")]
  public DocumentModel.Vml.FillMethodValues? Method { get; set; }
  
  
  /// <summary>
  ///   Detect Mouse Click
  /// </summary>
  [SchemaAttr("o:detectmouseclick")]
  public Boolean? DetectMouseClick { get; set; }
  
  
  /// <summary>
  ///   Title
  /// </summary>
  [SchemaAttr("o:title")]
  public String? Title { get; set; }
  
  
  /// <summary>
  ///   Secondary Color Opacity
  /// </summary>
  [SchemaAttr("o:opacity2")]
  public String? Opacity2 { get; set; }
  
  
  /// <summary>
  ///   Recolor Fill as Picture
  /// </summary>
  [SchemaAttr("recolor")]
  public Boolean? Recolor { get; set; }
  
  
  /// <summary>
  ///   Rotate Fill with Shape
  /// </summary>
  [SchemaAttr("rotate")]
  public Boolean? Rotate { get; set; }
  
  
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  [SchemaAttr("r:id")]
  public String? RelationshipId { get; set; }
  
  
  /// <summary>
  ///   FillExtendedProperties.
  /// </summary>
  public DocumentModel.Vml.Office.FillExtendedProperties? FillExtendedProperties { get; set; }
  
}
