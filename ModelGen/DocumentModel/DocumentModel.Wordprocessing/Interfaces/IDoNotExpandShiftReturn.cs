namespace DocumentModel.Wordprocessing;

/// <summary>
/// Don't Justify Lines Ending in Soft Line Break.
/// </summary>
public interface IDoNotExpandShiftReturn // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
