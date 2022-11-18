namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the StartMargin Class.
/// </summary>
public interface IStartMargin // : DocumentFormat.OpenXml.Wordprocessing.TableWidthType
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
