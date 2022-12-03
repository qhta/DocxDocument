namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TupleSetRow Class.
/// </summary>
public interface TupleSetRow // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<TupleSetRowItem>? TupleSetRowItems { get ; set; }
  
}
