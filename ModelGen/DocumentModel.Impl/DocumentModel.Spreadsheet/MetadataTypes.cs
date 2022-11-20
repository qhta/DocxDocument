namespace DocumentModel.Spreadsheet;

/// <summary>
/// Metadata Types Collection.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMetadataType))]
public class MetadataTypes: IMetadataTypes
{
  /// <summary>
  /// Metadata Type Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
