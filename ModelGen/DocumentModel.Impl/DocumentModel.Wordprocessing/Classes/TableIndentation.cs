namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableIndentation Class.
/// </summary>
public partial class TableIndentationImpl: ModelElementImpl, TableIndentation
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.TableIndentation? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableIndentation?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TableIndentationImpl(): base() {}
  
  public TableIndentationImpl(DocumentFormat.OpenXml.Wordprocessing.TableIndentation openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// w
  /// </summary>
  public Int32? Width
  {
    get => (System.Int32?)OpenXmlElement?.Width?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Width = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// type
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthUnitKind? Type
  {
    get => (DocumentModel.Wordprocessing.TableWidthUnitKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues?)value;
    }
  }
  
}
