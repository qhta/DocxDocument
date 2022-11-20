namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Display Visual Indication of Grammatical Errors.
/// </summary>
public interface IHideGrammaticalErrors // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
