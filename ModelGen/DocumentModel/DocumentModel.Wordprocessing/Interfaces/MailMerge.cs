namespace DocumentModel.Wordprocessing;

/// <summary>
/// Mail Merge Settings.
/// </summary>
public interface MailMerge
{
  /// <summary>
  /// Source Document Type.
  /// </summary>
  public MailMergeDocumentKind? MainDocumentType { get ; set; }
  
  /// <summary>
  /// Data Source Type.
  /// </summary>
  public MailMergeDataKind? DataType { get ; set; }
  
  /// <summary>
  /// Merged Document Destination.
  /// </summary>
  public MailMergeDestinationKind? Destination { get ; set; }
  
  /// <summary>
  /// Office Data Source Object Settings.
  /// </summary>
  public DataSourceObject? DataSourceObject { get ; set; }
  
}
