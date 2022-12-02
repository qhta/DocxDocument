namespace DocumentModel.Drawing;

/// <summary>
/// Defines the OpenXmlGridlinesElement Class.
/// </summary>
public interface IOpenXmlGridlinesElement // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
