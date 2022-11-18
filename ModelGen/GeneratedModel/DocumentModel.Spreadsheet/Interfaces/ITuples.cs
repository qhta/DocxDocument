namespace DocumentModel.Spreadsheet;

/// <summary>
/// Tuples.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITuple))]
public interface ITuples // : DocumentFormat.OpenXml.Spreadsheet.TuplesType
{
  /// <summary>
  /// Member Name Count
  /// </summary>
  public uint? MemberNameCount { get ; set; }
  
}
