namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Rule.
/// </summary>
public interface IRule // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public IExtensionList? ExtensionList { get ; set; }
  
}
