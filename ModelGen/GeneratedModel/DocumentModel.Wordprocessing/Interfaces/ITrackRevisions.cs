namespace DocumentModel.Wordprocessing;

/// <summary>
/// Track Revisions to Document.
/// </summary>
public interface ITrackRevisions // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
