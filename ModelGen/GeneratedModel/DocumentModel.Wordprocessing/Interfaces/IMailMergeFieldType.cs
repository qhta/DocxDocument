namespace DocumentModel.Wordprocessing;

/// <summary>
/// Merge Field Mapping.
/// </summary>
public interface IMailMergeFieldType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Merge Field Mapping Type
  /// </summary>
  public MailMergeOdsoField? Val { get ; set; }
  
}
