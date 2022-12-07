namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableRowHeight Class.
/// </summary>
public class TableRowHeightImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.TableRowHeight>, TableRowHeight
{
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
