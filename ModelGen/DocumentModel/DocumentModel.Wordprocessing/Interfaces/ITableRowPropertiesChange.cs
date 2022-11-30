namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Row Properties.
/// </summary>
public interface ITableRowPropertiesChange // : DocumentModel.ITypedOpenXmlCompositeElement
{
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
  
  /// <summary>
  /// Previous Table Row Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IPreviousTableRowProperties? PreviousTableRowProperties { get ; set; }
  
}
