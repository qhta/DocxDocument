namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableWidth Class.
/// </summary>
public interface ITableWidth // : DocumentFormat.OpenXml.Wordprocessing.TableWidthType
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
