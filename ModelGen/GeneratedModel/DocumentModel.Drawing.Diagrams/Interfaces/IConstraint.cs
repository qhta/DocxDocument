namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Constraint.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IExtensionList))]
public interface IConstraint // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  public Constraint? Type { get ; set; }
  
  /// <summary>
  /// For
  /// </summary>
  public ConstraintRelationship? For { get ; set; }
  
  /// <summary>
  /// For Name
  /// </summary>
  public string? ForName { get ; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public Element? PointType { get ; set; }
  
  /// <summary>
  /// Reference Type
  /// </summary>
  public Constraint? ReferenceType { get ; set; }
  
  /// <summary>
  /// Reference For
  /// </summary>
  public ConstraintRelationship? ReferenceFor { get ; set; }
  
  /// <summary>
  /// Reference For Name
  /// </summary>
  public string? ReferenceForName { get ; set; }
  
  /// <summary>
  /// Reference Point Type
  /// </summary>
  public Element? ReferencePointType { get ; set; }
  
  /// <summary>
  /// Operator
  /// </summary>
  public BoolOperator? Operator { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public double? Val { get ; set; }
  
  /// <summary>
  /// Factor
  /// </summary>
  public double? Fact { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IExtensionList? ExtensionList { get ; set; }
  
}
