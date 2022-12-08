namespace DocumentModel.Drawings;

/// <summary>
/// Tab List.
/// </summary>
public class TabStopListImpl: ModelElementImpl, TabStopList
{
  public DocumentFormat.OpenXml.Drawing.TabStopList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.TabStopList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<TabStop>? TabStops
  {
    get;
    set;
  }
  
}
