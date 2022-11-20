namespace DocumentModel.Spreadsheet;

/// <summary>
/// Value Metadata.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMetadataBlock))]
public class ValueMetadata: IValueMetadata
{
  /// <summary>
  /// Metadata Block Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
