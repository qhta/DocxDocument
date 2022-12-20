namespace DocumentModel.Wordprocessing;

/// <summary>
/// Combo Box List Item.
/// </summary>
public partial class ListItemImpl: ModelElementImpl, ListItem
{
  public DocumentFormat.OpenXml.Wordprocessing.ListItem? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ListItem?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ListItemImpl(): base() {}
  
  public ListItemImpl(DocumentFormat.OpenXml.Wordprocessing.ListItem openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// List Entry Display Text
  /// </summary>
  public String? DisplayText
  {
    get => (System.String?)OpenXmlElement?.DisplayText?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DisplayText = (System.String?)value;
    }
  }
  
  /// <summary>
  /// List Entry Value
  /// </summary>
  public String? Value
  {
    get => (System.String?)OpenXmlElement?.Value?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Value = (System.String?)value;
    }
  }
  
}
