namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Row Properties.
/// </summary>
public partial class TableRowPropertiesChangeImpl: ModelElementImpl, TableRowPropertiesChange
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.TableRowPropertiesChange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableRowPropertiesChange?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
  /// Previous Table Row Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.PreviousTableRowProperties? PreviousTableRowProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.PreviousTableRowPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.PreviousTableRowPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
