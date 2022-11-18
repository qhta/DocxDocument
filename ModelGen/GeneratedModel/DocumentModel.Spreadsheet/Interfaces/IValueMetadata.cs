namespace DocumentModel.Spreadsheet;

/// <summary>
/// Value Metadata.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMetadataBlock))]
public interface IValueMetadata // : DocumentFormat.OpenXml.Spreadsheet.MetadataBlocksType
{
  /// <summary>
  /// Metadata Block Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
