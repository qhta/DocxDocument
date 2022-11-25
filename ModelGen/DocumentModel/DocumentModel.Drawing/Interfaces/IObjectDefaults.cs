namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ObjectDefaults Class.
/// </summary>
public interface IObjectDefaults // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shape Default.
  /// </summary>
  public DocumentModel.Drawing.IDefaultShapeDefinitionType? ShapeDefault { get ; set; }
  
  /// <summary>
  /// Line Default.
  /// </summary>
  public DocumentModel.Drawing.IDefaultShapeDefinitionType? LineDefault { get ; set; }
  
  /// <summary>
  /// Text Default.
  /// </summary>
  public DocumentModel.Drawing.IDefaultShapeDefinitionType? TextDefault { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
