namespace DocumentModel.Spreadsheet;

/// <summary>
/// Cell Metadata.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMetadataBlock))]
public interface ICellMetadata // : DocumentFormat.OpenXml.Spreadsheet.MetadataBlocksType
{
  /// <summary>
  /// Metadata Block Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
