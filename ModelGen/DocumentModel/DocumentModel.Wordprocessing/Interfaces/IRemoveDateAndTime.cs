namespace DocumentModel.Wordprocessing;

/// <summary>
/// Remove Date and Time from Annotations.
/// </summary>
public interface IRemoveDateAndTime // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
