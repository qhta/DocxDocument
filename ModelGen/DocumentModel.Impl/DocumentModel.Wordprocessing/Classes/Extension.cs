namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Extension Class.
/// </summary>
public class ExtensionImpl: ModelElementImpl, Extension
{
  public DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// uri, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Uri
  {
    get => (String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
}
