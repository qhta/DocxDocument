namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Rule.
/// </summary>
public class Rule : CollectionItem
{
  /// <summary>
  ///   Constraint Type
  /// </summary>
  public Constraint? Type { get; set; }
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
  ///   Value
  /// </summary>
  public Double? Val { get; set; }
  /// <summary>
  ///   Factor
  /// </summary>
  public Double? Fact { get; set; }
  /// <summary>
  ///   Max Value
  /// </summary>
  public Double? Max { get; set; }
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}