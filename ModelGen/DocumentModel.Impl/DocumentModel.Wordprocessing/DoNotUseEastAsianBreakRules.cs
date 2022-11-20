namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Compress Compressible Characters When Using Document Grid.
/// </summary>
public class DoNotUseEastAsianBreakRules: IDoNotUseEastAsianBreakRules
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
