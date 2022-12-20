namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveBookmarkType Class.
/// </summary>
public partial class MoveBookmarkTypeImpl: ModelElementImpl, MoveBookmarkType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
    get => (System.String?)OpenXmlElement?.Author?.Value;
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
    get => (System.DateTime?)OpenXmlElement?.Date?.Value;
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
