namespace DocumentModel.Wordprocessing;

/// <summary>
/// Automatically Hyphenate Document Contents When Displayed.
/// </summary>
public interface IAutoHyphenation // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
