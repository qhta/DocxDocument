namespace DocumentModel.Presentation;

/// <summary>
/// Programmable Extensibility Tag.
/// </summary>
public interface ITag // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public string? Val { get ; set; }
  
}
