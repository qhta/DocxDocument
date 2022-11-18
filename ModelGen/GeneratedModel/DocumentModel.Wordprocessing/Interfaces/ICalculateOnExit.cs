namespace DocumentModel.Wordprocessing;

/// <summary>
/// Recalculate Fields When Current Field Is Modified.
/// </summary>
public interface ICalculateOnExit // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
