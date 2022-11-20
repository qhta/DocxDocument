namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate WordPerfect 6.x Paragraph Justification.
/// </summary>
public interface IWordPerfectJustification // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
