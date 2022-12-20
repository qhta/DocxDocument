namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableLayout Class.
/// </summary>
public partial class TableLayoutImpl: ModelElementImpl, TableLayout
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.TableLayout? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableLayout?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TableLayoutImpl(): base() {}
  
  public TableLayoutImpl(DocumentFormat.OpenXml.Wordprocessing.TableLayout openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Table Layout Setting
  /// </summary>
  public DocumentModel.Wordprocessing.TableLayoutKind? Type
  {
    get => (DocumentModel.Wordprocessing.TableLayoutKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.TableLayoutValues?)value;
    }
  }
  
}
