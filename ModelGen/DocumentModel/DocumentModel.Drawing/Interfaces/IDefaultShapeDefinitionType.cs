namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DefaultShapeDefinitionType Class.
/// </summary>
public interface IDefaultShapeDefinitionType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Visual Properties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// BodyProperties.
  /// </summary>
  public IBodyProperties? BodyProperties { get ; set; }
  
  /// <summary>
  /// ListStyle.
  /// </summary>
  public IListStyle? ListStyle { get ; set; }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public IShapeStyle? ShapeStyle { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
