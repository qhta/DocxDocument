namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Borders Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IBorder))]
public interface IBorders // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Border Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
