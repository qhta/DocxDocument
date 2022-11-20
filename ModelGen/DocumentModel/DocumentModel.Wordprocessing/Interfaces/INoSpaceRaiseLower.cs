namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Increase Line Height for Raised/Lowered Text.
/// </summary>
public interface INoSpaceRaiseLower // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
