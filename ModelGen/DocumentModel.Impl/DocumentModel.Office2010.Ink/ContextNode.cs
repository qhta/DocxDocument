namespace DocumentModel.Office2010.Ink;

/// <summary>
/// Defines the ContextNode Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Ink.ISourceLink))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Ink.IDestinationLink))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Ink.IContextNodeProperty))]
public class ContextNode: IContextNode
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// type
  /// </summary>
  public string? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// rotatedBoundingBox
  /// </summary>
  public List<string>? RotatedBoundingBox
  {
    get;
    set;
  }
  
  /// <summary>
  /// alignmentLevel
  /// </summary>
  public int? AlignmentLevel
  {
    get;
    set;
  }
  
  /// <summary>
  /// contentType
  /// </summary>
  public int? ContentType
  {
    get;
    set;
  }
  
  /// <summary>
  /// ascender
  /// </summary>
  public string? Ascender
  {
    get;
    set;
  }
  
  /// <summary>
  /// descender
  /// </summary>
  public string? Descender
  {
    get;
    set;
  }
  
  /// <summary>
  /// baseline
  /// </summary>
  public string? Baseline
  {
    get;
    set;
  }
  
  /// <summary>
  /// midline
  /// </summary>
  public string? Midline
  {
    get;
    set;
  }
  
  /// <summary>
  /// customRecognizerId
  /// </summary>
  public string? CustomRecognizerId
  {
    get;
    set;
  }
  
  /// <summary>
  /// mathML
  /// </summary>
  public string? MathML
  {
    get;
    set;
  }
  
  /// <summary>
  /// mathStruct
  /// </summary>
  public string? MathStruct
  {
    get;
    set;
  }
  
  /// <summary>
  /// mathSymbol
  /// </summary>
  public string? MathSymbol
  {
    get;
    set;
  }
  
  /// <summary>
  /// beginModifierType
  /// </summary>
  public string? BeginModifierType
  {
    get;
    set;
  }
  
  /// <summary>
  /// endModifierType
  /// </summary>
  public string? EndModifierType
  {
    get;
    set;
  }
  
  /// <summary>
  /// rotationAngle
  /// </summary>
  public int? RotationAngle
  {
    get;
    set;
  }
  
  /// <summary>
  /// hotPoints
  /// </summary>
  public List<string>? HotPoints
  {
    get;
    set;
  }
  
  /// <summary>
  /// centroid
  /// </summary>
  public string? Centroid
  {
    get;
    set;
  }
  
  /// <summary>
  /// semanticType
  /// </summary>
  public string? SemanticType
  {
    get;
    set;
  }
  
  /// <summary>
  /// shapeName
  /// </summary>
  public string? ShapeName
  {
    get;
    set;
  }
  
  /// <summary>
  /// shapeGeometry
  /// </summary>
  public List<string>? ShapeGeometry
  {
    get;
    set;
  }
  
}
