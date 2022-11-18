namespace DocumentModel.Wordprocessing;

/// <summary>
/// Never Kern Punctuation Characters.
/// </summary>
public interface INoPunctuationKerning // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
