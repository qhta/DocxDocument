namespace DocumentModel.Wordprocessing;

/// <summary>
/// Ignore Minimum and Exact Line Height for First Line on Page.
/// </summary>
public interface ISuppressTopSpacing // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
