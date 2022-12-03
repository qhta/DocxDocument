namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Row Properties.
/// </summary>
public interface TableRowProperties // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<ConditionalFormatStyle>? ConditionalFormatStyles { get ; set; }
  
  public Collection<String>? DivIds { get ; set; }
  
  public Collection<Int32>? GridBefores { get ; set; }
  
  public Collection<Int32>? GridAfters { get ; set; }
  
  public Collection<TableWidthType>? WidthBeforeTableRows { get ; set; }
  
  public Collection<TableWidthType>? WidthAfterTableRows { get ; set; }
  
  public Collection<TableRowHeight>? TableRowHeights { get ; set; }
  
  public Collection<Boolean>? Hiddens { get ; set; }
  
  public Collection<OnOffOnlyKind>? CantSplits { get ; set; }
  
  public Collection<OnOffOnlyKind>? TableHeaders { get ; set; }
  
  public Collection<TableWidthType>? TableCellSpacings { get ; set; }
  
  public Collection<TableRowAlignmentKind>? TableJustifications { get ; set; }
  
  public TrackChangeType? Inserted { get ; set; }
  
  public TrackChangeType? Deleted { get ; set; }
  
  public TableRowPropertiesChange? TableRowPropertiesChange { get ; set; }
  
  public TrackChangeType? ConflictInsertion { get ; set; }
  
  public TrackChangeType? ConflictDeletion { get ; set; }
  
}
