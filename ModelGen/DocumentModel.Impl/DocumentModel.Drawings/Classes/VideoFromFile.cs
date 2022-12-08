namespace DocumentModel.Drawings;

/// <summary>
/// Video from File.
/// </summary>
public class VideoFromFileImpl: ModelElementImpl, VideoFromFile
{
  public DocumentFormat.OpenXml.Drawing.VideoFromFile? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.VideoFromFile?)_OpenXmlElement;
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
