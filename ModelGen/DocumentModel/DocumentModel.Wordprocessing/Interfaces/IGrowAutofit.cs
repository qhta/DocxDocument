namespace DocumentModel.Wordprocessing;

/// <summary>
/// Allow Tables to AutoFit Into Page Margins.
/// </summary>
public interface IGrowAutofit // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
