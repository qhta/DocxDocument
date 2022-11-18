namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Strike Class.
/// </summary>
public interface IStrike // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
