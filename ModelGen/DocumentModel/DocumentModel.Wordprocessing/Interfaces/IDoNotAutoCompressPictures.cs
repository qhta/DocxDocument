namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Automatically Compress Images.
/// </summary>
public interface IDoNotAutoCompressPictures // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
