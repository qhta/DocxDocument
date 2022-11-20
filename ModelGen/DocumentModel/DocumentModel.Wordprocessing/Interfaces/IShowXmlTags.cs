namespace DocumentModel.Wordprocessing;

/// <summary>
/// Show Visual Indicators for Custom XML Markup Start/End Locations.
/// </summary>
public interface IShowXmlTags // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
