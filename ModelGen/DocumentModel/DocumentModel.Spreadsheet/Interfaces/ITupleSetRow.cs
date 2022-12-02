namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TupleSetRow Class.
/// </summary>
public interface ITupleSetRow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ITupleSetRowItem>? TupleSetRowItems { get ; set; }
  
}
