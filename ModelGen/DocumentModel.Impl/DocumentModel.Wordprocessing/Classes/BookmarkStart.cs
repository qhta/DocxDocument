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
  
  public BookmarkStartImpl(): base() {}
  
  public BookmarkStartImpl(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// name
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// colFirst
  /// </summary>
  public Int32? ColumnFirst
  {
    get => (System.Int32?)OpenXmlElement?.ColumnFirst?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ColumnFirst = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// colLast
  /// </summary>
  public Int32? ColumnLast
  {
    get => (System.Int32?)OpenXmlElement?.ColumnLast?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ColumnLast = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  public DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? DisplacedByCustomXml
  {
    get => (DocumentModel.Wordprocessing.DisplacedByCustomXmlKind?)OpenXmlElement?.DisplacedByCustomXml?.Value;
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
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
