namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sheet Id.
/// </summary>
public interface ISheetId // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Sheet Id
  /// </summary>
  public uint? Val { get ; set; }
  
}
