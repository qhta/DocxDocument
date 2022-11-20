namespace DocumentModel.Wordprocessing;

/// <summary>
/// Footnote and Endnote Numbering Restart Location.
/// </summary>
public class NumberingRestart: INumberingRestart
{
  /// <summary>
  /// Automatic Numbering Restart Value
  /// </summary>
  public RestartNumberValues? Val
  {
    get;
    set;
  }
  
}
