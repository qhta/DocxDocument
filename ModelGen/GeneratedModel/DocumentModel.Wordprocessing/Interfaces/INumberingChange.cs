namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Paragraph Numbering Properties.
/// </summary>
public interface INumberingChange // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// original
  /// </summary>
  public string? Original { get ; set; }
  
  /// <summary>
  /// author
  /// </summary>
  public string? Author { get ; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public string? Id { get ; set; }
  
}
