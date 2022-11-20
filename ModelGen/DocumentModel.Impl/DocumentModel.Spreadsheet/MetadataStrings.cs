namespace DocumentModel.Spreadsheet;

/// <summary>
/// Metadata String Store.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICharacterValue))]
public class MetadataStrings: IMetadataStrings
{
  /// <summary>
  /// MDX Metadata String Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
