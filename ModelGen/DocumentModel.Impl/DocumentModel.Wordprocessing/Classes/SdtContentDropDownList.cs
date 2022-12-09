namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDropDownList Class.
/// </summary>
public class SdtContentDropDownListImpl: ModelElementImpl, SdtContentDropDownList
{
  public DocumentFormat.OpenXml.Wordprocessing.SdtContentDropDownList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtContentDropDownList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Drop-down List Last Saved Value
  /// </summary>
  public String? LastValue
  {
    get => (String?)OpenXmlElement?.LastValue?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LastValue = (System.String?)value;
    }
  }
  
  public Collection<ListItem>? ListItems
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
