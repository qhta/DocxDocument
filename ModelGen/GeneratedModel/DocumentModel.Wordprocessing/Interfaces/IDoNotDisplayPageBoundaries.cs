namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Display Visual Boundary For Header/Footer or Between Pages.
/// </summary>
public interface IDoNotDisplayPageBoundaries // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
