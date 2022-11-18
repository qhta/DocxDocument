namespace DocumentModel.Wordprocessing;

/// <summary>
/// Use ANSI Kerning Pairs from Fonts.
/// </summary>
public interface IUseAnsiKerningPairs // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
