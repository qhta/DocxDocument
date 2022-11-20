namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Hyphenate Words in ALL CAPITAL LETTERS.
/// </summary>
public interface IDoNotHyphenateCaps // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
