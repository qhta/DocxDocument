namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TupleSetRows Class.
/// </summary>
public interface ITupleSetRows // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ITupleSetRow>? TupleSetRows { get ; set; }
  
}
