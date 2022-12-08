namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableRowHeight Class.
/// </summary>
public class TableRowHeightImpl: ModelElementImpl, TableRowHeight
{
  public DocumentFormat.OpenXml.Wordprocessing.TableRowHeight? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableRowHeight?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Table Row Height
  /// </summary>
  public UInt32? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Row Height Type
  /// </summary>
  public HeightRuleKind? HeightType
  {
    get => (HeightRuleKind?)OpenXmlElement?.HeightType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HeightType = (DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues?)value;
    }
  }
  
}
