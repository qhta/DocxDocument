namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table-Level Property Exceptions.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPreviousTablePropertyExceptions))]
public interface ITablePropertyExceptionsChange // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
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
  
  /// <summary>
  /// Previous Table-Level Property Exceptions.
  /// </summary>
  public IPreviousTablePropertyExceptions? PreviousTablePropertyExceptions { get ; set; }
  
}
