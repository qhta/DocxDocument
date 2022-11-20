namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the MergeCells Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMergeCell))]
public class MergeCells: IMergeCells
{
  /// <summary>
  /// Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
