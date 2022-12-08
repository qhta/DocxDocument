namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Entry Properties.
/// </summary>
public class DocPartPropertiesImpl: ModelElementImpl, DocPartProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.DocPartProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocPartProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Entry Name.
  /// </summary>
  public DocPartName? DocPartName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Associated Paragraph Style Name.
  /// </summary>
  public String? StyleId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Entry Categorization.
  /// </summary>
  public Category? Category
  {
    get;
    set;
  }
  
  /// <summary>
  /// Entry Types.
  /// </summary>
  public DocPartTypes? DocPartTypes
  {
    get;
    set;
  }
  
  /// <summary>
  /// Entry Insertion Behaviors.
  /// </summary>
  public Behaviors? Behaviors
  {
    get;
    set;
  }
  
  /// <summary>
  /// Description for Entry.
  /// </summary>
  public String? Description
  {
    get;
    set;
  }
  
  /// <summary>
  /// Entry ID.
  /// </summary>
  public String? DocPartId
  {
    get;
    set;
  }
  
}
