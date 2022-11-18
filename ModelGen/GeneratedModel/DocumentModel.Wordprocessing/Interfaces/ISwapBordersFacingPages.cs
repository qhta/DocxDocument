namespace DocumentModel.Wordprocessing;

/// <summary>
/// Swap Paragraph Borders on Odd Numbered Pages.
/// </summary>
public interface ISwapBordersFacingPages // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
