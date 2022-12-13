namespace DocumentModel.Drawings;

/// <summary>
/// Constraint.
/// </summary>
public interface Constraint
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  public DocumentModel.Drawings.ConstraintKind? Type { get ; set; }
  
  /// <summary>
  /// For
  /// </summary>
  public DocumentModel.Drawings.ConstraintRelationshipKind? For { get ; set; }
  
  /// <summary>
  /// For Name
  /// </summary>
  public String? ForName { get ; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public DocumentModel.Drawings.ElementKind? PointType { get ; set; }
  
  /// <summary>
  /// Reference Type
  /// </summary>
  public DocumentModel.Drawings.ConstraintKind? ReferenceType { get ; set; }
  
  /// <summary>
  /// Reference For
  /// </summary>
  public DocumentModel.Drawings.ConstraintRelationshipKind? ReferenceFor { get ; set; }
  
  /// <summary>
  /// Reference For Name
  /// </summary>
  public String? ReferenceForName { get ; set; }
  
  /// <summary>
  /// Reference Point Type
  /// </summary>
  public DocumentModel.Drawings.ElementKind? ReferencePointType { get ; set; }
  
  /// <summary>
  /// Operator
  /// </summary>
  public DocumentModel.Drawings.BoolOperatorKind? Operator { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public Double? Val { get ; set; }
  
  /// <summary>
  /// Factor
  /// </summary>
  public Double? Fact { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
