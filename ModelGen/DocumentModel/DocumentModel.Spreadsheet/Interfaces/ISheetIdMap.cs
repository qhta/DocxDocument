namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sheet Id Map.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ISheetId))]
public interface ISheetIdMap // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Sheet Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
