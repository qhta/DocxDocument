namespace DocumentModel.Drawings;

/// <summary>
/// Rule.
/// </summary>
public interface Rule
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  public DocumentModel.Drawings.ConstraintKind? Type { get ; set; }
  
  /// <summary>
  /// For
  /// </summary>
  public DocumentModel.Drawings.ConstraintRelationshipKind? For { get ; set; }
  
  /// <summary>
  /// For Name
  /// </summary>
  public String? ForName { get ; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public DocumentModel.Drawings.ElementKind? PointType { get ; set; }
  
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
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
