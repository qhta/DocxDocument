namespace DocumentModel.Vml;

/// <summary>
/// Regroup Entry.
/// </summary>
public class EntryImpl: ModelElementImpl, Entry
{
  public DocumentFormat.OpenXml.Vml.Office.Entry? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.Entry?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public EntryImpl(): base() {}
  
  public EntryImpl(DocumentFormat.OpenXml.Vml.Office.Entry openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// New Group ID
  /// </summary>
  public Int32? New
  {
    get => (System.Int32?)OpenXmlElement?.New?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.New = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Old Group ID
  /// </summary>
  public Int32? Old
  {
    get => (System.Int32?)OpenXmlElement?.Old?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Old = (System.Int32?)value;
    }
  }
  
}
