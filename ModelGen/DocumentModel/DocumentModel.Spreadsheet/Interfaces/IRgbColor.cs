namespace DocumentModel.Spreadsheet;

/// <summary>
/// RGB Color.
/// </summary>
public interface IRgbColor // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Alpha Red Green Blue
  /// </summary>
  public IHexBinaryValue? Rgb { get ; set; }
  
}
