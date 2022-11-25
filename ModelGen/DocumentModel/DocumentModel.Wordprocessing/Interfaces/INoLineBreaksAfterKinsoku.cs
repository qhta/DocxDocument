namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom Set of Characters Which Cannot End a Line.
/// </summary>
public interface INoLineBreaksAfterKinsoku // : DocumentModel.ITypedOpenXmlLeafElement
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
