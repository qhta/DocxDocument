namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Row Properties.
/// </summary>
public class TableStyleConditionalFormattingTableRowPropertiesImpl: ModelElementImpl, TableStyleConditionalFormattingTableRowProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Boolean>? Hiddens
  {
    get;
    set;
  }
  
  public Collection<OnOffOnlyKind>? CantSplits
  {
    get;
    set;
  }
  
  public Collection<OnOffOnlyKind>? TableHeaders
  {
    get;
    set;
  }
  
  public Collection<TableWidthType>? TableCellSpacings
  {
    get;
    set;
  }
  
  public Collection<TableRowAlignmentKind>? TableJustifications
  {
    get;
    set;
  }
  
}
