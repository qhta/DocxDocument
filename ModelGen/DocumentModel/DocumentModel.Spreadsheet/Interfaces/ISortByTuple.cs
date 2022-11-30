namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sort By Tuple.
/// </summary>
public interface ISortByTuple // : DocumentModel.Spreadsheet.ITuplesType
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ITuple>? Tuples { get ; set; }
  
}
