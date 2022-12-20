namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Grid Column Definitions.
/// </summary>
public partial class TableGridChangeImpl: ModelElementImpl, TableGridChange
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.TableGridChange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableGridChange?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TableGridChangeImpl(): base() {}
  
  public TableGridChangeImpl(DocumentFormat.OpenXml.Wordprocessing.TableGridChange openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
  /// Previous Table Grid.
  /// </summary>
  public DocumentModel.Wordprocessing.PreviousTableGrid? PreviousTableGrid
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTableGrid>();
        if (item != null)
          return new DocumentModel.Wordprocessing.PreviousTableGridImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTableGrid>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.PreviousTableGridImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
