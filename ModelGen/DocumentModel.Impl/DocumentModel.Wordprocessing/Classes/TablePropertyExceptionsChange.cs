namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table-Level Property Exceptions.
/// </summary>
public partial class TablePropertyExceptionsChangeImpl: ModelElementImpl, TablePropertyExceptionsChange
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptionsChange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptionsChange?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TablePropertyExceptionsChangeImpl(): base() {}
  
  public TablePropertyExceptionsChangeImpl(DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptionsChange openXmlElement): base(openXmlElement)
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
  
  /// <summary>
  /// Previous Table-Level Property Exceptions.
  /// </summary>
  public DocumentModel.Wordprocessing.PreviousTablePropertyExceptions? PreviousTablePropertyExceptions
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions>();
        if (item != null)
          return new DocumentModel.Wordprocessing.PreviousTablePropertyExceptionsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTablePropertyExceptions>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.PreviousTablePropertyExceptionsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
