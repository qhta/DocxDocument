namespace DocumentModel.Office2010.Ink;

/// <summary>
/// Defines the ContextNode Class.
/// </summary>
public interface IContextNode // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public String? Type { get ; set; }
  
  /// <summary>
  /// rotatedBoundingBox
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.StringValue>? RotatedBoundingBox { get ; set; }
  
  /// <summary>
  /// alignmentLevel
  /// </summary>
  public Int32? AlignmentLevel { get ; set; }
  
  /// <summary>
  /// contentType
  /// </summary>
  public Int32? ContentType { get ; set; }
  
  /// <summary>
  /// ascender
  /// </summary>
  public String? Ascender { get ; set; }
  
  /// <summary>
  /// descender
  /// </summary>
  public String? Descender { get ; set; }
  
  /// <summary>
  /// baseline
  /// </summary>
  public String? Baseline { get ; set; }
  
  /// <summary>
  /// midline
  /// </summary>
  public String? Midline { get ; set; }
  
  /// <summary>
  /// customRecognizerId
  /// </summary>
  public String? CustomRecognizerId { get ; set; }
  
  /// <summary>
  /// mathML
  /// </summary>
  public String? MathML { get ; set; }
  
  /// <summary>
  /// mathStruct
  /// </summary>
  public String? MathStruct { get ; set; }
  
  /// <summary>
  /// mathSymbol
  /// </summary>
  public String? MathSymbol { get ; set; }
  
  /// <summary>
  /// beginModifierType
  /// </summary>
  public String? BeginModifierType { get ; set; }
  
  /// <summary>
  /// endModifierType
  /// </summary>
  public String? EndModifierType { get ; set; }
  
  /// <summary>
  /// rotationAngle
  /// </summary>
  public Int32? RotationAngle { get ; set; }
  
  /// <summary>
  /// hotPoints
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.StringValue>? HotPoints { get ; set; }
  
  /// <summary>
  /// centroid
  /// </summary>
  public String? Centroid { get ; set; }
  
  /// <summary>
  /// semanticType
  /// </summary>
  public String? SemanticType { get ; set; }
  
  /// <summary>
  /// shapeName
  /// </summary>
  public String? ShapeName { get ; set; }
  
  /// <summary>
  /// shapeGeometry
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.StringValue>? ShapeGeometry { get ; set; }
  
}
