namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Balance Text Columns within a Section.
/// </summary>
public interface INoColumnBalance // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
