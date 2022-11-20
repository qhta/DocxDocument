namespace DocumentModel.Wordprocessing;

/// <summary>
/// Ignore Mixed Content When Validating Custom XML Markup.
/// </summary>
public interface IIgnoreMixedContent // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
