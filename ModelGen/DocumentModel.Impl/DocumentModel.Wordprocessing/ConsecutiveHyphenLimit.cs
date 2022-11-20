namespace DocumentModel.Wordprocessing;

/// <summary>
/// Maximum Number of Consecutively Hyphenated Lines.
/// </summary>
public class ConsecutiveHyphenLimit: IConsecutiveHyphenLimit
{
  /// <summary>
  /// val
  /// </summary>
  public ushort? Val
  {
    get;
    set;
  }
  
}
