namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Display Visual Indication of Spelling Errors.
/// </summary>
public interface IHideSpellingErrors // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
