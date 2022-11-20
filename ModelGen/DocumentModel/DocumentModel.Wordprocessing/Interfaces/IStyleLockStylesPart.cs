namespace DocumentModel.Wordprocessing;

/// <summary>
/// Prevent Replacement of Styles Part.
/// </summary>
public interface IStyleLockStylesPart // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
