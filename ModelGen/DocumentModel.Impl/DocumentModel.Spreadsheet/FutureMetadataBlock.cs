namespace DocumentModel.Spreadsheet;

/// <summary>
/// Future Metadata Block.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public class FutureMetadataBlock: IFutureMetadataBlock
{
  /// <summary>
  /// Future Feature Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
