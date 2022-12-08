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
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author
  {
    get;
    set;
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get;
    set;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Previous Table Cell Properties.
  /// </summary>
  public PreviousTableCellProperties? PreviousTableCellProperties
  {
    get;
    set;
  }
  
}
