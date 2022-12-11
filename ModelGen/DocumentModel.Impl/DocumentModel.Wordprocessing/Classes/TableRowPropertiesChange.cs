namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Row Properties.
/// </summary>
public class TableRowPropertiesChangeImpl: ModelElementImpl, TableRowPropertiesChange
{
  public DocumentFormat.OpenXml.Wordprocessing.TableRowPropertiesChange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableRowPropertiesChange?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TableRowPropertiesChangeImpl(): base() {}
  
  public TableRowPropertiesChangeImpl(DocumentFormat.OpenXml.Wordprocessing.TableRowPropertiesChange openXmlElement): base(openXmlElement)
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
  /// Previous Table Row Properties.
  /// </summary>
  public PreviousTableRowProperties? PreviousTableRowProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
