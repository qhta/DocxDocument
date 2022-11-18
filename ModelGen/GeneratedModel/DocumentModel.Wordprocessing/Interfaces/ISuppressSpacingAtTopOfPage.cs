namespace DocumentModel.Wordprocessing;

/// <summary>
/// Ignore Minimum Line Height for First Line on Page.
/// </summary>
public interface ISuppressSpacingAtTopOfPage // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
