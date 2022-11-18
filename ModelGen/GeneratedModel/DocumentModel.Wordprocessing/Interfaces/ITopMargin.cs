namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Cell Top Margin Default.
/// </summary>
public interface ITopMargin // : DocumentFormat.OpenXml.Wordprocessing.TableWidthType
{
  /// <summary>
  /// Table Width Value
  /// </summary>
  public string? Width { get ; set; }
  
  /// <summary>
  /// Table Width Type
  /// </summary>
  public TableWidthUnit? Type { get ; set; }
  
}
