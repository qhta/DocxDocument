namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Row Properties.
/// </summary>
public partial interface TableRowPropertiesChange
{
  /// <summary>
  /// author
  /// </summary>
  public String? Author { get; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date { get; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// Previous Table Row Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.PreviousTableRowProperties? PreviousTableRowProperties { get; set; }
  
}
