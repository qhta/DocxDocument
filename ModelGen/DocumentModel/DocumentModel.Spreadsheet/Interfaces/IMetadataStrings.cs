namespace DocumentModel.Spreadsheet;

/// <summary>
/// Metadata String Store.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICharacterValue))]
public interface IMetadataStrings // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// MDX Metadata String Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
