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
  /// Previous Table Properties.
  /// </summary>
  public PreviousTableProperties? PreviousTableProperties
  {
    get;
    set;
  }
  
}
