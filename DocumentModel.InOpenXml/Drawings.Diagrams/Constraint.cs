namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Constraint.
/// </summary>
public class Constraint : CollectionItem
{
  /// <summary>
  ///   Constraint Type
  /// </summary>
  public ConstraintType? Type { get; set; }
  /// <summary>
  ///   For
  /// </summary>
  public ConstraintRelationship? For { get; set; }
  /// <summary>
  ///   For Name
  /// </summary>
  public string? ForName { get; set; }
  /// <summary>
  ///   Data Point Type
  /// </summary>
  public ElementType? PointType { get; set; }
  /// <summary>
  ///   Reference Type
  /// </summary>
  public Constraint? ReferenceType { get; set; }
  /// <summary>
  ///   Reference For
  /// </summary>
  public ConstraintRelationship? ReferenceFor { get; set; }
  /// <summary>
  ///   Reference For Name
  /// </summary>
  public string? ReferenceForName { get; set; }
  /// <summary>
  ///   Reference Point Type
  /// </summary>
  public ElementType? ReferencePointType { get; set; }
  /// <summary>
  ///   Operator
  /// </summary>
  public BoolOperator? Operator { get; set; }
  /// <summary>
  ///   Value
  /// </summary>
  public Double? Val { get; set; }
  /// <summary>
  ///   Factor
  /// </summary>
  public Double? Fact { get; set; }
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}