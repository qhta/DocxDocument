namespace DocumentModel.Drawing;

/// <summary>
/// Video from File.
/// </summary>
public interface IVideoFromFile // : DocumentModel.ITypedOpenXmlCompositeElement
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
