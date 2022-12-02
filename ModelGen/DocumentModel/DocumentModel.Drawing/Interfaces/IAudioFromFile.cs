namespace DocumentModel.Drawing;

/// <summary>
/// Audio from File.
/// </summary>
public interface IAudioFromFile // : DocumentModel.ITypedOpenXmlCompositeElement
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
