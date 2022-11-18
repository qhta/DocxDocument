namespace DocumentModel.Spreadsheet;

/// <summary>
/// Future Metadata.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFutureMetadataBlock))]
public interface IFutureMetadata // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Metadata Type Name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Future Metadata Block Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
