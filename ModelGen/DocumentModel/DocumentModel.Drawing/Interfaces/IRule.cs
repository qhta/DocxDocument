namespace DocumentModel.Drawing;

/// <summary>
/// Rule.
/// </summary>
public interface IRule // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  public DocumentModel.Drawing.ConstraintKind? Type { get ; set; }
  
  /// <summary>
  /// For
  /// </summary>
  public DocumentModel.Drawing.ConstraintRelationshipKind? For { get ; set; }
  
  /// <summary>
  /// For Name
  /// </summary>
  public System.String? ForName { get ; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public DocumentModel.Drawing.ElementKind? PointType { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public System.Double? Val { get ; set; }
  
  /// <summary>
  /// Factor
  /// </summary>
  public System.Double? Fact { get ; set; }
  
  /// <summary>
  /// Max Value
  /// </summary>
  public System.Double? Max { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
