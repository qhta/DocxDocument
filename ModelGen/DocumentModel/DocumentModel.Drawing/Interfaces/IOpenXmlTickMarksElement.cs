namespace DocumentModel.Drawing;

/// <summary>
/// Defines the OpenXmlTickMarksElement Class.
/// </summary>
public interface IOpenXmlTickMarksElement // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawing.TickMarksType? Type { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
