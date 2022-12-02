namespace DocumentModel.Drawing;

/// <summary>
/// Defines the OpenXmlGridlinesElement Class.
/// </summary>
public interface IOpenXmlGridlinesElement // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
