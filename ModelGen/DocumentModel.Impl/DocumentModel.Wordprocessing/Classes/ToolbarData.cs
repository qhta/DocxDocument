namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ToolbarData Class.
/// </summary>
public class ToolbarDataImpl: ModelElementImpl, ToolbarData
{
  public DocumentFormat.OpenXml.Office.Word.ToolbarData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.ToolbarData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ToolbarDataImpl(): base() {}
  
  public ToolbarDataImpl(DocumentFormat.OpenXml.Office.Word.ToolbarData openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// id
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
