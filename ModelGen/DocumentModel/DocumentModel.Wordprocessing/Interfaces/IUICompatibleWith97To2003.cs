namespace DocumentModel.Wordprocessing;

/// <summary>
/// Disable Features Incompatible With Earlier Word Processing Formats.
/// </summary>
public interface IUICompatibleWith97To2003 // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
