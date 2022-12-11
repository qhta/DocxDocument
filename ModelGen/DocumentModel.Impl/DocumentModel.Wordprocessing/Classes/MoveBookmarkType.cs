namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveBookmarkType Class.
/// </summary>
public class MoveBookmarkTypeImpl: ModelElementImpl, MoveBookmarkType
{
  public DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MoveBookmarkTypeImpl(): base() {}
  
  public MoveBookmarkTypeImpl(DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author
  {
    get => (String?)OpenXmlElement?.Author?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Author = (System.String?)value;
    }
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get => (DateTime?)OpenXmlElement?.Date?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Date = (System.DateTime?)value;
    }
  }
  
  /// <summary>
  /// name
  /// </summary>
  public String? Name
  {
    get => (String?)OpenXmlElement?.Name?.Value;
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
    get => (Int32?)OpenXmlElement?.ColumnFirst?.Value;
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
    get => (Int32?)OpenXmlElement?.ColumnLast?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ColumnLast = (System.Int32?)value;
    }
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
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
