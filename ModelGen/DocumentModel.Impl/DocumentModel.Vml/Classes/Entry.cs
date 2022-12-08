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
  
  /// <summary>
  /// New Group ID
  /// </summary>
  public Int32? New
  {
    get;
    set;
  }
  
  /// <summary>
  /// Old Group ID
  /// </summary>
  public Int32? Old
  {
    get;
    set;
  }
  
}
