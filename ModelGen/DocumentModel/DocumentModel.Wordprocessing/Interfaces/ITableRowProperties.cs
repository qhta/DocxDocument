namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Row Properties.
/// </summary>
public interface ITableRowProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IConditionalFormatStyle>? ConditionalFormatStyles { get ; set; }
  
  public Collection<String>? DivIds { get ; set; }
  
  public Collection<Int32>? GridBefores { get ; set; }
  
  public Collection<Int32>? GridAfters { get ; set; }
  
  public Collection<ITableWidthType>? WidthBeforeTableRows { get ; set; }
  
  public Collection<ITableWidthType>? WidthAfterTableRows { get ; set; }
  
  public Collection<ITableRowHeight>? TableRowHeights { get ; set; }
  
  public Collection<Boolean>? Hiddens { get ; set; }
  
  public Collection<OnOffOnlyKind>? CantSplits { get ; set; }
  
  public Collection<OnOffOnlyKind>? TableHeaders { get ; set; }
  
  public Collection<ITableWidthType>? TableCellSpacings { get ; set; }
  
  public Collection<TableRowAlignmentKind>? TableJustifications { get ; set; }
  
  public ITrackChangeType? Inserted { get ; set; }
  
  public ITrackChangeType? Deleted { get ; set; }
  
  public ITableRowPropertiesChange? TableRowPropertiesChange { get ; set; }
  
  public ITrackChangeType? ConflictInsertion { get ; set; }
  
  public ITrackChangeType? ConflictDeletion { get ; set; }
  
}
