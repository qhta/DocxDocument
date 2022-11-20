namespace DocumentModel.Wordprocessing;

/// <summary>
/// Increase Priority Of Font Size During Font Substitution.
/// </summary>
public interface ISubFontBySize // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
