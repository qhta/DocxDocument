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
  /// Data Point Type
  /// </summary>
  public ElementKind? PointType { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList3? ExtensionList { get ; set; }
  
}
