namespace DocumentModel.Drawing;

/// <summary>
/// Constraint.
/// </summary>
public interface IConstraint // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  public DocumentModel.Drawing.ConstraintKind? Type { get ; set; }
  
  /// <summary>
  /// For
  /// </summary>
  public DocumentModel.Drawing.ConstraintRelationshipKind? For { get ; set; }
  
  /// <summary>
  /// For Name
  /// </summary>
  public System.String? ForName { get ; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public DocumentModel.Drawing.ElementKind? PointType { get ; set; }
  
  /// <summary>
  /// Reference Type
  /// </summary>
  public DocumentModel.Drawing.ConstraintKind? ReferenceType { get ; set; }
  
  /// <summary>
  /// Reference For
  /// </summary>
  public DocumentModel.Drawing.ConstraintRelationshipKind? ReferenceFor { get ; set; }
  
  /// <summary>
  /// Reference For Name
  /// </summary>
  public System.String? ReferenceForName { get ; set; }
  
  /// <summary>
  /// Reference Point Type
  /// </summary>
  public DocumentModel.Drawing.ElementKind? ReferencePointType { get ; set; }
  
  /// <summary>
  /// Operator
  /// </summary>
  public DocumentModel.Drawing.BoolOperatorKind? Operator { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public System.Double? Val { get ; set; }
  
  /// <summary>
  /// Factor
  /// </summary>
  public System.Double? Fact { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
