namespace DocumentModel.Vml;

/// <summary>
/// Defines the Fill Class.
/// </summary>
public interface IFill // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  public DocumentModel.Vml.FillKind? Type { get ; set; }
  
  /// <summary>
  /// Fill Toggle
  /// </summary>
  public System.Boolean? On { get ; set; }
  
  /// <summary>
  /// Primary Color
  /// </summary>
  public System.String? Color { get ; set; }
  
  /// <summary>
  /// Primary Color Opacity
  /// </summary>
  public System.String? Opacity { get ; set; }
  
  /// <summary>
  /// Secondary Color
  /// </summary>
  public System.String? Color2 { get ; set; }
  
  /// <summary>
  /// Fill Image Source
  /// </summary>
  public System.String? Source { get ; set; }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  public System.String? Href { get ; set; }
  
  /// <summary>
  /// Alternate Image Reference Location
  /// </summary>
  public System.String? AlternateImageReference { get ; set; }
  
  /// <summary>
  /// Fill Image Size
  /// </summary>
  public System.String? Size { get ; set; }
  
  /// <summary>
  /// Fill Image Origin
  /// </summary>
  public System.String? Origin { get ; set; }
  
  /// <summary>
  /// Fill Image Position
  /// </summary>
  public System.String? Position { get ; set; }
  
  /// <summary>
  /// Image Aspect Ratio
  /// </summary>
  public DocumentModel.Vml.ImageAspectKind? Aspect { get ; set; }
  
  /// <summary>
  /// Intermediate Colors
  /// </summary>
  public System.String? Colors { get ; set; }
  
  /// <summary>
  /// Gradient Angle
  /// </summary>
  public System.Decimal? Angle { get ; set; }
  
  /// <summary>
  /// Align Image With Shape
  /// </summary>
  public System.Boolean? AlignShape { get ; set; }
  
  /// <summary>
  /// Gradient Center
  /// </summary>
  public System.String? Focus { get ; set; }
  
  /// <summary>
  /// Radial Gradient Size
  /// </summary>
  public System.String? FocusSize { get ; set; }
  
  /// <summary>
  /// Radial Gradient Center
  /// </summary>
  public System.String? FocusPosition { get ; set; }
  
  /// <summary>
  /// Gradient Fill Method
  /// </summary>
  public DocumentModel.Vml.FillMethodKind? Method { get ; set; }
  
  /// <summary>
  /// Detect Mouse Click
  /// </summary>
  public System.Boolean? DetectMouseClick { get ; set; }
  
  /// <summary>
  /// Title
  /// </summary>
  public System.String? Title { get ; set; }
  
  /// <summary>
  /// Secondary Color Opacity
  /// </summary>
  public System.String? Opacity2 { get ; set; }
  
  /// <summary>
  /// Recolor Fill as Picture
  /// </summary>
  public System.Boolean? Recolor { get ; set; }
  
  /// <summary>
  /// Rotate Fill with Shape
  /// </summary>
  public System.Boolean? Rotate { get ; set; }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public System.String? RelationshipId { get ; set; }
  
  /// <summary>
  /// FillExtendedProperties.
  /// </summary>
  public DocumentModel.Vml.Office.IFillExtendedProperties? FillExtendedProperties { get ; set; }
  
}
