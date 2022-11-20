namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Constraint.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IExtensionList))]
public class Constraint: IConstraint
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  public ConstraintValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// For
  /// </summary>
  public ConstraintRelationshipValues? For
  {
    get;
    set;
  }
  
  /// <summary>
  /// For Name
  /// </summary>
  public string? ForName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public ElementValues? PointType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Reference Type
  /// </summary>
  public ConstraintValues? ReferenceType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Reference For
  /// </summary>
  public ConstraintRelationshipValues? ReferenceFor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Reference For Name
  /// </summary>
  public string? ReferenceForName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Reference Point Type
  /// </summary>
  public ElementValues? ReferencePointType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Operator
  /// </summary>
  public BoolOperatorValues? Operator
  {
    get;
    set;
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public double? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// Factor
  /// </summary>
  public double? Fact
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
