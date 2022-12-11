namespace DocumentModel.Drawings;

/// <summary>
/// Rule.
/// </summary>
public interface Rule
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  public ConstraintKind? Type { get ; set; }
  
  /// <summary>
  /// For
  /// </summary>
  public ConstraintRelationshipKind? For { get ; set; }
  
  /// <summary>
  /// For Name
  /// </summary>
  public String? ForName { get ; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public ElementKind? PointType { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public Double? Val { get ; set; }
  
  /// <summary>
  /// Factor
  /// </summary>
  public Double? Fact { get ; set; }
  
  /// <summary>
  /// Max Value
  /// </summary>
  public Double? Max { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
