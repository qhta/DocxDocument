namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Constraint.
/// </summary>
public interface IConstraint // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  public ConstraintValues? Type { get ; set; }
  
  /// <summary>
  /// For
  /// </summary>
  public ConstraintRelationshipValues? For { get ; set; }
  
  /// <summary>
  /// For Name
  /// </summary>
  public String? ForName { get ; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public ElementValues? PointType { get ; set; }
  
  /// <summary>
  /// Reference Type
  /// </summary>
  public ConstraintValues? ReferenceType { get ; set; }
  
  /// <summary>
  /// Reference For
  /// </summary>
  public ConstraintRelationshipValues? ReferenceFor { get ; set; }
  
  /// <summary>
  /// Reference For Name
  /// </summary>
  public String? ReferenceForName { get ; set; }
  
  /// <summary>
  /// Reference Point Type
  /// </summary>
  public ElementValues? ReferencePointType { get ; set; }
  
  /// <summary>
  /// Operator
  /// </summary>
  public BoolOperatorValues? Operator { get ; set; }
  
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
  public IExtensionList? ExtensionList { get ; set; }
  
}
