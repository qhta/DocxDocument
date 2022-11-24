namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Cell Properties.
/// </summary>
public interface ITableCellPropertiesChange // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// author
  /// </summary>
  public String? Author { get ; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// Previous Table Cell Properties.
  /// </summary>
  public IPreviousTableCellProperties? PreviousTableCellProperties { get ; set; }
  
}
