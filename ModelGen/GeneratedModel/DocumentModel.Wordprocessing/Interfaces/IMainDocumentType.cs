namespace DocumentModel.Wordprocessing;

/// <summary>
/// Source Document Type.
/// </summary>
public interface IMainDocumentType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Mail Merge Source Document Type
  /// </summary>
  public MailMergeDocument? Val { get ; set; }
  
}
