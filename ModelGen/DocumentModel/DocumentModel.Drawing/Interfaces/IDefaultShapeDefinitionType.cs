namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DefaultShapeDefinitionType Class.
/// </summary>
public interface IDefaultShapeDefinitionType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Visual Properties.
  /// </summary>
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// BodyProperties.
  /// </summary>
  public DocumentModel.Drawing.IBodyProperties? BodyProperties { get ; set; }
  
  /// <summary>
  /// ListStyle.
  /// </summary>
  public DocumentModel.Drawing.IListStyle? ListStyle { get ; set; }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public DocumentModel.Drawing.IShapeStyle? ShapeStyle { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
