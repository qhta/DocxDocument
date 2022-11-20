namespace DocumentModel.Vml;

/// <summary>
/// Defines the Fill Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IFillExtendedProperties))]
public interface IFill // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  public FillTypeValues? Type { get ; set; }
  
  /// <summary>
  /// Fill Toggle
  /// </summary>
  public ITrueFalseValue? On { get ; set; }
  
  /// <summary>
  /// Primary Color
  /// </summary>
  public string? Color { get ; set; }
  
  /// <summary>
  /// Primary Color Opacity
  /// </summary>
  public string? Opacity { get ; set; }
  
  /// <summary>
  /// Secondary Color
  /// </summary>
  public string? Color2 { get ; set; }
  
  /// <summary>
  /// Fill Image Source
  /// </summary>
  public string? Source { get ; set; }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  public string? Href { get ; set; }
  
  /// <summary>
  /// Alternate Image Reference Location
  /// </summary>
  public string? AlternateImageReference { get ; set; }
  
  /// <summary>
  /// Fill Image Size
  /// </summary>
  public string? Size { get ; set; }
  
  /// <summary>
  /// Fill Image Origin
  /// </summary>
  public string? Origin { get ; set; }
  
  /// <summary>
  /// Fill Image Position
  /// </summary>
  public string? Position { get ; set; }
  
  /// <summary>
  /// Image Aspect Ratio
  /// </summary>
  public ImageAspectValues? Aspect { get ; set; }
  
  /// <summary>
  /// Intermediate Colors
  /// </summary>
  public string? Colors { get ; set; }
  
  /// <summary>
  /// Gradient Angle
  /// </summary>
  public decimal? Angle { get ; set; }
  
  /// <summary>
  /// Align Image With Shape
  /// </summary>
  public ITrueFalseValue? AlignShape { get ; set; }
  
  /// <summary>
  /// Gradient Center
  /// </summary>
  public string? Focus { get ; set; }
  
  /// <summary>
  /// Radial Gradient Size
  /// </summary>
  public string? FocusSize { get ; set; }
  
  /// <summary>
  /// Radial Gradient Center
  /// </summary>
  public string? FocusPosition { get ; set; }
  
  /// <summary>
  /// Gradient Fill Method
  /// </summary>
  public FillMethodValues? Method { get ; set; }
  
  /// <summary>
  /// Detect Mouse Click
  /// </summary>
  public ITrueFalseValue? DetectMouseClick { get ; set; }
  
  /// <summary>
  /// Title
  /// </summary>
  public string? Title { get ; set; }
  
  /// <summary>
  /// Secondary Color Opacity
  /// </summary>
  public string? Opacity2 { get ; set; }
  
  /// <summary>
  /// Recolor Fill as Picture
  /// </summary>
  public ITrueFalseValue? Recolor { get ; set; }
  
  /// <summary>
  /// Rotate Fill with Shape
  /// </summary>
  public ITrueFalseValue? Rotate { get ; set; }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public string? RelationshipId { get ; set; }
  
  /// <summary>
  /// FillExtendedProperties.
  /// </summary>
  public IFillExtendedProperties? FillExtendedProperties { get ; set; }
  
}
