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
  
  public AudioFromFileImpl(): base() {}
  
  public AudioFromFileImpl(DocumentFormat.OpenXml.Drawing.AudioFromFile openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Linked Relationship ID
  /// </summary>
  public String? Link
  {
    get => (String?)OpenXmlElement?.Link?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Link = (System.String?)value;
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
