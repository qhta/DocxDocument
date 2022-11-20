namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Consolidation References.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDataReference))]
public class DataReferences: IDataReferences
{
  /// <summary>
  /// Data Consolidation Reference Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
