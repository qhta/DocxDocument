namespace DocumentModel.Wordprocessing;

/// <summary>
/// Page Border Excludes Header.
/// </summary>
public interface IBordersDoNotSurroundHeader // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
