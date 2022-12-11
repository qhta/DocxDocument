namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table-Level Property Exceptions.
/// </summary>
public class TablePropertyExceptionsChangeImpl: ModelElementImpl, TablePropertyExceptionsChange
{
  public DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptionsChange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptionsChange?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
  
  /// <summary>
  /// Previous Table-Level Property Exceptions.
  /// </summary>
  public PreviousTablePropertyExceptions? PreviousTablePropertyExceptions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
