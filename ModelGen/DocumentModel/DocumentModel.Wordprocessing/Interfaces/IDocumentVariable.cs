namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Document Variable.
/// </summary>
public interface IDocumentVariable // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Document Variable Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Document Variable Value
  /// </summary>
  public System.String? Val { get ; set; }
  
}
