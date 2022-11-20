namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Cell Left Margin Exception.
/// </summary>
public interface ILeftMargin // : DocumentFormat.OpenXml.Wordprocessing.TableWidthType
{
  /// <summary>
  /// Table Width Value
  /// </summary>
  public string? Width { get ; set; }
  
  /// <summary>
  /// Table Width Type
  /// </summary>
  public TableWidthUnitValues? Type { get ; set; }
  
}
