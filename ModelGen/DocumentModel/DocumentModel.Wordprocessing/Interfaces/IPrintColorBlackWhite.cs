namespace DocumentModel.Wordprocessing;

/// <summary>
/// Print Colors as Black And White without Dithering.
/// </summary>
public interface IPrintColorBlackWhite // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
