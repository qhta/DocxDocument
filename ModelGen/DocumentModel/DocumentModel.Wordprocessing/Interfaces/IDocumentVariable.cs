namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Document Variable.
/// </summary>
public interface IDocumentVariable // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Document Variable Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Document Variable Value
  /// </summary>
  public String? Val { get ; set; }
  
}
