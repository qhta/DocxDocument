namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ToolbarData Class.
/// </summary>
public partial class ToolbarDataImpl: ModelElementImpl, ToolbarData
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.Word.ToolbarData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.ToolbarData?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
