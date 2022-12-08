namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Conditional Table Formatting Properties.
/// </summary>
public class TableStylePropertiesImpl: ModelElementImpl, TableStyleProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Type
  /// </summary>
  public TableStyleOverrideKind? Type
  {
    get => (TableStyleOverrideKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.TableStyleOverrideValues?)value;
    }
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Paragraph Properties.
  /// </summary>
  public StyleParagraphProperties? StyleParagraphProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Run Properties.
  /// </summary>
  public RunPropertiesBaseStyle? RunPropertiesBaseStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Properties.
  /// </summary>
  public TableStyleConditionalFormattingTableProperties? TableStyleConditionalFormattingTableProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Row Properties.
  /// </summary>
  public TableStyleConditionalFormattingTableRowProperties? TableStyleConditionalFormattingTableRowProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Cell Properties.
  /// </summary>
  public TableStyleConditionalFormattingTableCellProperties? TableStyleConditionalFormattingTableCellProperties
  {
    get;
    set;
  }
  
}
