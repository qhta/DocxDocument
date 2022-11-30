namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the TupleSetRows Class.
/// </summary>
public interface ITupleSetRows // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Excel.ITupleSetRow>? TupleSetRows { get ; set; }
  
}
