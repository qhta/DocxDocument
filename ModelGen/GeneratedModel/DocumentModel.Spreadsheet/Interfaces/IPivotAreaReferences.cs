namespace DocumentModel.Spreadsheet;

/// <summary>
/// References.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotAreaReference))]
public interface IPivotAreaReferences // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pivot Filter Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
