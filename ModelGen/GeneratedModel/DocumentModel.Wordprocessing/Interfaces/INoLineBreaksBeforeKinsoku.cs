namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom Set Of Characters Which Cannot Begin A Line.
/// </summary>
public interface INoLineBreaksBeforeKinsoku // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// lang
  /// </summary>
  public string? Language { get ; set; }
  
  /// <summary>
  /// val
  /// </summary>
  public string? Val { get ; set; }
  
}
