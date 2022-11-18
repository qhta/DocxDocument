namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPreviousTableProperties))]
public interface ITablePropertiesChange // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  /// Previous Table Properties.
  /// </summary>
  public IPreviousTableProperties? PreviousTableProperties { get ; set; }
  
}
