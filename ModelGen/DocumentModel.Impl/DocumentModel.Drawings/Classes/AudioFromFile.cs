namespace DocumentModel.Drawings;

/// <summary>
/// Audio from File.
/// </summary>
public class AudioFromFileImpl: ModelElementImpl, AudioFromFile
{
  public DocumentFormat.OpenXml.Drawing.AudioFromFile? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AudioFromFile?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Linked Relationship ID
  /// </summary>
  public String? Link
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
