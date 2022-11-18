namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the EndMargin Class.
/// </summary>
public interface IEndMargin // : DocumentFormat.OpenXml.Wordprocessing.TableWidthType
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
