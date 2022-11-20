namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Cell Left Margin Default.
/// </summary>
public interface ITableCellLeftMargin // : DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType
{
  /// <summary>
  /// w
  /// </summary>
  public short? Width { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public TableWidthValues? Type { get ; set; }
  
}
