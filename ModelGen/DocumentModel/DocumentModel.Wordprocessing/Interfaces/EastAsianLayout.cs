namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the EastAsianLayout Class.
/// </summary>
public interface EastAsianLayout
{
  /// <summary>
  /// Display Brackets Around Two Lines in One
  /// </summary>
  public CombineBracketKind? CombineBrackets { get ; set; }
  
}
