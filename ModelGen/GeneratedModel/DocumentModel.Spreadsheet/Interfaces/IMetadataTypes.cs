namespace DocumentModel.Spreadsheet;

/// <summary>
/// Metadata Types Collection.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMetadataType))]
public interface IMetadataTypes // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Metadata Type Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
