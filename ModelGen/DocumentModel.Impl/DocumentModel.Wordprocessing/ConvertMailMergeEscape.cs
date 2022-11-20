namespace DocumentModel.Wordprocessing;

/// <summary>
/// Treat Backslash Quotation Delimiter as Two Quotation Marks.
/// </summary>
public class ConvertMailMergeEscape: IConvertMailMergeEscape
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
