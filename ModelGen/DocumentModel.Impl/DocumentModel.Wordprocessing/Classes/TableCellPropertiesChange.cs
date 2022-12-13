namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Cell Properties.
/// </summary>
public class TableCellPropertiesChangeImpl: ModelElementImpl, TableCellPropertiesChange
{
  public DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TableCellPropertiesChangeImpl(): base() {}
  
  public TableCellPropertiesChangeImpl(DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange openXmlElement): base(openXmlElement)
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
  /// Previous Table Cell Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.PreviousTableCellProperties? PreviousTableCellProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
