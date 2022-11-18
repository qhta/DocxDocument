namespace DocumentModel.Spreadsheet;

/// <summary>
/// Vertical Alignment.
/// </summary>
public interface IVerticalTextAlignment // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Value
  /// </summary>
  public VerticalAlignmentRun? Val { get ; set; }
  
}
