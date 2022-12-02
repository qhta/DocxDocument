namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TupleSetHeaders Class.
/// </summary>
public interface ITupleSetHeaders // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ITupleSetHeader>? TupleSetHeaders { get ; set; }
  
}
