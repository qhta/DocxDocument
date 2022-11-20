namespace DocumentModel.Wordprocessing;

/// <summary>
/// Use Strict Kinsoku Rules for Japanese Text.
/// </summary>
public interface IStrictFirstAndLastChars // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
