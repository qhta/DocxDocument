namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the WidowControl Class.
/// </summary>
public interface IWidowControl // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
