namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom Set Of Characters Which Cannot Begin A Line.
/// </summary>
public interface INoLineBreaksBeforeKinsoku // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// lang
  /// </summary>
  public System.String? Language { get ; set; }
  
  /// <summary>
  /// val
  /// </summary>
  public System.String? Val { get ; set; }
  
}
