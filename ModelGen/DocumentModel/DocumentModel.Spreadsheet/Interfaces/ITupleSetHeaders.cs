namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TupleSetHeaders Class.
/// </summary>
public interface ITupleSetHeaders // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ITupleSetHeader>? TupleSetHeaders { get ; set; }
  
}
