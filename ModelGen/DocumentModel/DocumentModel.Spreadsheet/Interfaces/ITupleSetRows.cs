namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TupleSetRows Class.
/// </summary>
public interface ITupleSetRows // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ITupleSetRow>? TupleSetRows { get ; set; }
  
}
