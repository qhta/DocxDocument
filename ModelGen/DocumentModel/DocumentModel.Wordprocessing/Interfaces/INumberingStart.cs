namespace DocumentModel.Wordprocessing;

/// <summary>
/// Footnote and Endnote Numbering Starting Value.
/// </summary>
public interface INumberingStart // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val
  /// </summary>
  public ushort? Val { get ; set; }
  
}
