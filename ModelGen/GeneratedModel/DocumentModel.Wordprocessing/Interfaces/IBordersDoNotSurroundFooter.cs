namespace DocumentModel.Wordprocessing;

/// <summary>
/// Page Border Excludes Footer.
/// </summary>
public interface IBordersDoNotSurroundFooter // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
