namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Name.
/// </summary>
public interface IDocPartName // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Name Value
  /// </summary>
  public string? Val { get ; set; }
  
  /// <summary>
  /// Built-In Entry
  /// </summary>
  public bool? Decorated { get ; set; }
  
}
