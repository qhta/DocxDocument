namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Row Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IConditionalFormatStyle))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IGridBefore))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IGridAfter))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableRowHeight))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDivId))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IHidden))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICantSplit))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableHeader))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableJustification))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IWidthBeforeTableRow))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IWidthAfterTableRow))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellSpacing))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IInserted))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDeleted))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IConflictInsertion))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IConflictDeletion))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableRowPropertiesChange))]
public interface ITableRowProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
}
