namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Row Properties.
/// </summary>
public interface ITableRowProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public DocumentModel.Wordprocessing.IConditionalFormatStyle? ConditionalFormatStyle { get ; set; }
  
  public System.String? DivId { get ; set; }
  
  public System.Int32? GridBefore { get ; set; }
  
  public System.Int32? GridAfter { get ; set; }
  
  public DocumentModel.Wordprocessing.ITableWidthType? WidthBeforeTableRow { get ; set; }
  
  public DocumentModel.Wordprocessing.ITableWidthType? WidthAfterTableRow { get ; set; }
  
  public DocumentModel.Wordprocessing.ITableRowHeight? TableRowHeight { get ; set; }
  
  public System.Boolean? Hidden { get ; set; }
  
  public DocumentModel.Wordprocessing.OnOffOnlyKind? CantSplit { get ; set; }
  
  public DocumentModel.Wordprocessing.OnOffOnlyKind? TableHeader { get ; set; }
  
  public DocumentModel.Wordprocessing.ITableWidthType? TableCellSpacing { get ; set; }
  
  public DocumentModel.Wordprocessing.TableRowAlignmentKind? TableJustification { get ; set; }
  
  public DocumentModel.Wordprocessing.ITrackChangeType? Inserted { get ; set; }
  
  public DocumentModel.Wordprocessing.ITrackChangeType? Deleted { get ; set; }
  
  public DocumentModel.Wordprocessing.ITableRowPropertiesChange? TableRowPropertiesChange { get ; set; }
  
  public DocumentModel.Office2010.Word.ITrackChangeType? ConflictInsertion { get ; set; }
  
  public DocumentModel.Office2010.Word.ITrackChangeType? ConflictDeletion { get ; set; }
  
}
