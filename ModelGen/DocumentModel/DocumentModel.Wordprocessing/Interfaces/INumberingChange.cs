namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Paragraph Numbering Properties.
/// </summary>
public interface INumberingChange // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// original
  /// </summary>
  public System.String? Original { get ; set; }
  
  /// <summary>
  /// author
  /// </summary>
  public System.String? Author { get ; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public System.DateTime? Date { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
}
