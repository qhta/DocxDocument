namespace DocumentModel.Wordprocessing;

/// <summary>
/// Source Document Type.
/// </summary>
public class MainDocumentType: IMainDocumentType
{
  /// <summary>
  /// Mail Merge Source Document Type
  /// </summary>
  public MailMergeDocumentValues? Val
  {
    get;
    set;
  }
  
}
