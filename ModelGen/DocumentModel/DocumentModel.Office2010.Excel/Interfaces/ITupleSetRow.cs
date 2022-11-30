namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the TupleSetRow Class.
/// </summary>
public interface ITupleSetRow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Excel.ITupleSetRowItem>? TupleSetRowItems { get ; set; }
  
}
