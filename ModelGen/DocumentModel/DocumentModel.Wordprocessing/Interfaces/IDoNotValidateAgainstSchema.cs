namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Validate Custom XML Markup Against Schemas.
/// </summary>
public interface IDoNotValidateAgainstSchema // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
