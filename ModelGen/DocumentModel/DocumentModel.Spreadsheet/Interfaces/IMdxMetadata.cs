namespace DocumentModel.Spreadsheet;

/// <summary>
/// MDX Metadata Information.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMdx))]
public interface IMdxMetadata // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// MDX Metadata Record Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
