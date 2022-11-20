namespace DocumentModel.Wordprocessing;

/// <summary>
/// Use Custom XML Element Names as Default Placeholder Text.
/// </summary>
public interface IAlwaysShowPlaceholderText // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
