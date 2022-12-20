namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableWidthType Class.
/// </summary>
public partial class TableWidthTypeImpl: ModelElementImpl, TableWidthType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.TableWidthType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableWidthType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TableWidthTypeImpl(): base() {}
  
  public TableWidthTypeImpl(DocumentFormat.OpenXml.Wordprocessing.TableWidthType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Table Width Value
  /// </summary>
  public String? Width
  {
    get => (System.String?)OpenXmlElement?.Width?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Width = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Table Width Type
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
