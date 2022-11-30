namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Row Properties.
/// </summary>
public interface ITableStyleConditionalFormattingTableRowProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Boolean? Hidden { get ; set; }
  
  public DocumentModel.Wordprocessing.OnOffOnlyKind? CantSplit { get ; set; }
  
  public DocumentModel.Wordprocessing.OnOffOnlyKind? TableHeader { get ; set; }
  
  public DocumentModel.Wordprocessing.ITableWidthType? TableCellSpacing { get ; set; }
  
  public DocumentModel.Wordprocessing.TableRowAlignmentKind? TableJustification { get ; set; }
  
}
