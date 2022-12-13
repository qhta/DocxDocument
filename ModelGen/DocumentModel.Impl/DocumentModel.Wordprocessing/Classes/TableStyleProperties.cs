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
  
  public TableStylePropertiesImpl(): base() {}
  
  public TableStylePropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Type
  /// </summary>
  public DocumentModel.Wordprocessing.TableStyleOverrideKind? Type
  {
    get => (DocumentModel.Wordprocessing.TableStyleOverrideKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.TableStyleOverrideValues?)value;
    }
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Paragraph Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.StyleParagraphProperties? StyleParagraphProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.RunPropertiesBaseStyle? RunPropertiesBaseStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableProperties? TableStyleConditionalFormattingTableProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Row Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? TableStyleConditionalFormattingTableRowProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Cell Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableCellProperties? TableStyleConditionalFormattingTableCellProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
