namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TupleSetRow Class.
/// </summary>
public interface ITupleSetRow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ITupleSetRowItem>? TupleSetRowItems { get ; set; }
  
}
