namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sort By Tuple.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITuple))]
public interface ISortByTuple // : DocumentFormat.OpenXml.Spreadsheet.TuplesType
{
  /// <summary>
  /// Member Name Count
  /// </summary>
  public uint? MemberNameCount { get ; set; }
  
}
