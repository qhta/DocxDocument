namespace DocumentModel.Wordprocessing;

/// <summary>
/// Treat Backslash Quotation Delimiter as Two Quotation Marks.
/// </summary>
public interface IConvertMailMergeEscape // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
