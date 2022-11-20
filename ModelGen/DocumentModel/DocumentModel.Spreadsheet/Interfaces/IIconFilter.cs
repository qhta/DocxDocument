namespace DocumentModel.Spreadsheet;

/// <summary>
/// Icon Filter.
/// </summary>
public interface IIconFilter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Icon Set
  /// </summary>
  public IconSetValues? IconSet { get ; set; }
  
  /// <summary>
  /// Icon Id
  /// </summary>
  public uint? IconId { get ; set; }
  
}
