namespace DocumentModel.Wordprocessing;

/// <summary>
/// Add Additional Space Below Baseline For Underlined East Asian Text.
/// </summary>
public interface ISpaceForUnderline // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
