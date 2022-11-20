namespace DocumentModel.Wordprocessing;

/// <summary>
/// ODSO Data Source Type.
/// </summary>
public class MailMergeSource: IMailMergeSource
{
  /// <summary>
  /// Data Source Type Value
  /// </summary>
  public MailMergeSourceValues? Val
  {
    get;
    set;
  }
  
}
