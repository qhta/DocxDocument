namespace DocumentModel.Office2019.Excel.ThreadedComments;

/// <summary>
/// Defines the Mention Class.
/// </summary>
public class Mention: IMention
{
  /// <summary>
  /// mentionpersonId, this property is only available in Office 2019 and later.
  /// </summary>
  public string? MentionpersonId
  {
    get;
    set;
  }
  
  /// <summary>
  /// mentionId, this property is only available in Office 2019 and later.
  /// </summary>
  public string? MentionId
  {
    get;
    set;
  }
  
  /// <summary>
  /// startIndex, this property is only available in Office 2019 and later.
  /// </summary>
  public uint? StartIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// length, this property is only available in Office 2019 and later.
  /// </summary>
  public uint? Length
  {
    get;
    set;
  }
  
}
