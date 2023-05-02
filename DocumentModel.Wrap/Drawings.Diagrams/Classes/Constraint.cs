namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Constraint.
/// </summary>
public class Constraint: ModelElement
{
  /// <summary>
  ///   Constraint Type
  /// </summary>
  public ConstraintKind? Type { get; set; }

  /// <summary>
  ///   For
  /// </summary>
  public ConstraintRelationshipKind? For { get; set; }

  /// <summary>
  ///   For Name
  /// </summary>
  public string? ForName { get; set; }

  /// <summary>
  ///   Data Point Type
  /// </summary>
  public ElementKind? PointType { get; set; }

  /// <summary>
  ///   Reference Type
  /// </summary>
  public ConstraintKind? ReferenceType { get; set; }

  /// <summary>
  ///   Reference For
  /// </summary>
  public ConstraintRelationshipKind? ReferenceFor { get; set; }

  /// <summary>
  ///   Reference For Name
  /// </summary>
  public string? ReferenceForName { get; set; }

  /// <summary>
  ///   Reference Point Type
  /// </summary>
  public ElementKind? ReferencePointType { get; set; }

  /// <summary>
  ///   Operator
  /// </summary>
  public BoolOperatorKind? Operator { get; set; }

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