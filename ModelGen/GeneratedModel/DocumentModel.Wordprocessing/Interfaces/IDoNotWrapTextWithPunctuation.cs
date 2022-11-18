namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Allow Hanging Punctuation With Character Grid.
/// </summary>
public interface IDoNotWrapTextWithPunctuation // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
