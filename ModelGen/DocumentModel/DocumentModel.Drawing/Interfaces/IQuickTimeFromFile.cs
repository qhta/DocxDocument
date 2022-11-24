namespace DocumentModel.Drawing;

/// <summary>
/// QuickTime from File.
/// </summary>
public interface IQuickTimeFromFile // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Linked Relationship ID
  /// </summary>
  public String? Link { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
