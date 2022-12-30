namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Rule.
/// </summary>
public partial class Rule
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ConstraintKind? Type { get; set; }
  
  /// <summary>
  /// For
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ConstraintRelationshipKind? For { get; set; }
  
  /// <summary>
  /// For Name
  /// </summary>
  public String? ForName { get; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ElementKind? PointType { get; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public Double? Val { get; set; }
  
  /// <summary>
  /// Factor
  /// </summary>
  public Double? Fact { get; set; }
  
  /// <summary>
  /// Max Value
  /// </summary>
  public Double? Max { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList { get; set; }
  
}
