namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Center Content on Lines With Exact Line Height.
/// </summary>
public interface INoExtraLineSpacing // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
