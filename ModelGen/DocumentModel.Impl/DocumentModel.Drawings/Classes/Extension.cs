namespace DocumentModel.Drawings;

/// <summary>
/// Extension.
/// </summary>
public class ExtensionImpl: ModelElementImpl, Extension
{
  public DocumentFormat.OpenXml.Drawing.Charts.Extension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Extension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ExtensionImpl(): base() {}
  
  public ExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.Extension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Uniform Resource Identifier
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
