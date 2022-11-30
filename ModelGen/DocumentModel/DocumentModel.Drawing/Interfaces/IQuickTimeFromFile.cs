namespace DocumentModel.Drawing;

/// <summary>
/// QuickTime from File.
/// </summary>
public interface IQuickTimeFromFile // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Linked Relationship ID
  /// </summary>
  public System.String? Link { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
