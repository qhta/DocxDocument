namespace DocumentModel.Spreadsheet;

/// <summary>
/// Range Sets.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRangeSet))]
public interface IRangeSets // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference and Page Item Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
