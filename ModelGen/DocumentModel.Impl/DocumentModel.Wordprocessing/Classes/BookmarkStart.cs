namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BookmarkStart Class.
/// </summary>
public class BookmarkStartImpl: ModelElementImpl, BookmarkStart
{
  public DocumentFormat.OpenXml.Wordprocessing.BookmarkStart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.BookmarkStart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// name
  /// </summary>
  public String? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// colFirst
  /// </summary>
  public Int32? ColumnFirst
  {
    get;
    set;
  }
  
  /// <summary>
  /// colLast
  /// </summary>
  public Int32? ColumnLast
  {
    get;
    set;
  }
  
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  public DisplacedByCustomXmlKind? DisplacedByCustomXml
  {
    get => (DisplacedByCustomXmlKind?)OpenXmlElement?.DisplacedByCustomXml?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DisplacedByCustomXml = (DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues?)value;
    }
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
}
