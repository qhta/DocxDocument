namespace DocumentModel.Wordprocessing;

/// <summary>
/// Combo Box List Item.
/// </summary>
public class ListItemImpl: ModelElementImpl, ListItem
{
  public DocumentFormat.OpenXml.Wordprocessing.ListItem? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ListItem?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// List Entry Display Text
  /// </summary>
  public String? DisplayText
  {
    get => (String?)OpenXmlElement?.DisplayText?.Value;
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
    get => (String?)OpenXmlElement?.Value?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Value = (System.String?)value;
    }
  }
  
}
