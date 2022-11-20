namespace DocumentModel.Wordprocessing;

/// <summary>
/// Only Save Custom XML Markup.
/// </summary>
public interface ISaveXmlDataOnly // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
