namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableRowHeight Class.
/// </summary>
public partial class TableRowHeightImpl: ModelElementImpl, TableRowHeight
{
  public DocumentFormat.OpenXml.Wordprocessing.TableRowHeight? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableRowHeight?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TableRowHeightImpl(): base() {}
  
  public TableRowHeightImpl(DocumentFormat.OpenXml.Wordprocessing.TableRowHeight openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Table Row Height
  /// </summary>
  public UInt32? Val
  {
    get => (System.UInt32?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Table Row Height Type
  /// </summary>
  public DocumentModel.Wordprocessing.HeightRuleKind? HeightType
  {
    get => (DocumentModel.Wordprocessing.HeightRuleKind?)OpenXmlElement?.HeightType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HeightType = (DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues?)value;
    }
  }
  
}
