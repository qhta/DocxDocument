namespace DocumentModel.Wordprocessing;

/// <summary>
/// Ignore Exact Line Height for Last Line on Page.
/// </summary>
public interface ISuppressBottomSpacing // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
