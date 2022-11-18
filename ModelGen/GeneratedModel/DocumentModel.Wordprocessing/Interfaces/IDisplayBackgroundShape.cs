namespace DocumentModel.Wordprocessing;

/// <summary>
/// Display Background Objects When Displaying Document.
/// </summary>
public interface IDisplayBackgroundShape // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
