namespace DocumentModel.Drawings;

/// <summary>
/// Constraint.
/// </summary>
public class Constraint
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  public ConstraintKind? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// For
  /// </summary>
  public ConstraintRelationshipKind? For
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public ElementKind? PointType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Reference Type
  /// </summary>
  public ConstraintKind? ReferenceType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Reference For
  /// </summary>
  public ConstraintRelationshipKind? ReferenceFor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Reference Point Type
  /// </summary>
  public ElementKind? ReferencePointType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Operator
  /// </summary>
  public BoolOperatorKind? Operator
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList3? ExtensionList
  {
    get;
    set;
  }
  
}
