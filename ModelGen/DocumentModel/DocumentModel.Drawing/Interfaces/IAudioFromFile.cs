namespace DocumentModel.Drawing;

/// <summary>
/// Audio from File.
/// </summary>
public interface IAudioFromFile // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Linked Relationship ID
  /// </summary>
  public System.String? Link { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
