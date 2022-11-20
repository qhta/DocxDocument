namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Show Visual Indicator For Invalid Custom XML Markup.
/// </summary>
public interface IDoNotDemarcateInvalidXml // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
