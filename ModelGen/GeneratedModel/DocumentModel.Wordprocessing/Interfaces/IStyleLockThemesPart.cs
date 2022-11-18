namespace DocumentModel.Wordprocessing;

/// <summary>
/// Prevent Modification of Themes Part.
/// </summary>
public interface IStyleLockThemesPart // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
