namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Extension Class.
/// </summary>
public partial class ExtensionImpl: ModelElementImpl, Extension
{
  public DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ExtensionImpl(): base() {}
  
  public ExtensionImpl(DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// uri, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
}
