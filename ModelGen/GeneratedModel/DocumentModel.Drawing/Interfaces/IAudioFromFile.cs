namespace DocumentModel.Drawing;

/// <summary>
/// Audio from File.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public interface IAudioFromFile // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Linked Relationship ID
  /// </summary>
  public string? Link { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
