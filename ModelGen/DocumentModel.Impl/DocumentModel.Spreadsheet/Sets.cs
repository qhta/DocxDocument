namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sets.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITupleSet))]
public class Sets: ISets
{
  /// <summary>
  /// Tuple Set Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
