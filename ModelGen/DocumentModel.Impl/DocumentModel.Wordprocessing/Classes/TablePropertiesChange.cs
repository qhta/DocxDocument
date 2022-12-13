namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Properties.
/// </summary>
public class TablePropertiesChangeImpl: ModelElementImpl, TablePropertiesChange
{
  public DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TablePropertiesChangeImpl(): base() {}
  
  public TablePropertiesChangeImpl(DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange openXmlElement): base(openXmlElement)
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
  /// Previous Table Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.PreviousTableProperties? PreviousTableProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
