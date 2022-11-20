namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Add Leading Between Lines of Text.
/// </summary>
public interface INoLeading // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
