namespace DocumentModel.Spreadsheet;

/// <summary>
/// Future Metadata Block.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public interface IFutureMetadataBlock // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Future Feature Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
