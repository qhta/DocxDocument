namespace DocumentModel.Spreadsheet;

/// <summary>
/// Cell Metadata.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMetadataBlock))]
public class CellMetadata: ICellMetadata
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
