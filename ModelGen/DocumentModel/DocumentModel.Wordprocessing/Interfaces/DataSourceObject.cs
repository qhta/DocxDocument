namespace DocumentModel.Wordprocessing;

/// <summary>
/// Office Data Source Object Settings.
/// </summary>
public interface DataSourceObject
{
  /// <summary>
  /// ODSO Data Source Type.
  /// </summary>
  public MailMergeSourceKind? MailMergeSource { get ; set; }
  
}
