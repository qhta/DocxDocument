namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Row Properties.
/// </summary>
public interface ITableStyleConditionalFormattingTableRowProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<Boolean>? Hiddens { get ; set; }
  
  public Collection<OnOffOnlyKind>? CantSplits { get ; set; }
  
  public Collection<OnOffOnlyKind>? TableHeaders { get ; set; }
  
  public Collection<ITableWidthType>? TableCellSpacings { get ; set; }
  
  public Collection<TableRowAlignmentKind>? TableJustifications { get ; set; }
  
}
