namespace DocumentModel.Wordprocessing;

/// <summary>
/// Footnote and Endnote Numbering Restart Location.
/// </summary>
public interface INumberingRestart // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Automatic Numbering Restart Value
  /// </summary>
  public RestartNumber? Val { get ; set; }
  
}
