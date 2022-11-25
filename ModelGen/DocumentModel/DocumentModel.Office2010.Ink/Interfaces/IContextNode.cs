namespace DocumentModel.Office2010.Ink;

/// <summary>
/// Defines the ContextNode Class.
/// </summary>
public interface IContextNode // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public System.String? Type { get ; set; }
  
  /// <summary>
  /// rotatedBoundingBox
  /// </summary>
  public System.Collections.Generic.List<System.String>? RotatedBoundingBox { get ; set; }
  
  /// <summary>
  /// alignmentLevel
  /// </summary>
  public System.Int32? AlignmentLevel { get ; set; }
  
  /// <summary>
  /// contentType
  /// </summary>
  public System.Int32? ContentType { get ; set; }
  
  /// <summary>
  /// ascender
  /// </summary>
  public System.String? Ascender { get ; set; }
  
  /// <summary>
  /// descender
  /// </summary>
  public System.String? Descender { get ; set; }
  
  /// <summary>
  /// baseline
  /// </summary>
  public System.String? Baseline { get ; set; }
  
  /// <summary>
  /// midline
  /// </summary>
  public System.String? Midline { get ; set; }
  
  /// <summary>
  /// customRecognizerId
  /// </summary>
  public System.String? CustomRecognizerId { get ; set; }
  
  /// <summary>
  /// mathML
  /// </summary>
  public System.String? MathML { get ; set; }
  
  /// <summary>
  /// mathStruct
  /// </summary>
  public System.String? MathStruct { get ; set; }
  
  /// <summary>
  /// mathSymbol
  /// </summary>
  public System.String? MathSymbol { get ; set; }
  
  /// <summary>
  /// beginModifierType
  /// </summary>
  public System.String? BeginModifierType { get ; set; }
  
  /// <summary>
  /// endModifierType
  /// </summary>
  public System.String? EndModifierType { get ; set; }
  
  /// <summary>
  /// rotationAngle
  /// </summary>
  public System.Int32? RotationAngle { get ; set; }
  
  /// <summary>
  /// hotPoints
  /// </summary>
  public System.Collections.Generic.List<System.String>? HotPoints { get ; set; }
  
  /// <summary>
  /// centroid
  /// </summary>
  public System.String? Centroid { get ; set; }
  
  /// <summary>
  /// semanticType
  /// </summary>
  public System.String? SemanticType { get ; set; }
  
  /// <summary>
  /// shapeName
  /// </summary>
  public System.String? ShapeName { get ; set; }
  
  /// <summary>
  /// shapeGeometry
  /// </summary>
  public System.Collections.Generic.List<System.String>? ShapeGeometry { get ; set; }
  
}
