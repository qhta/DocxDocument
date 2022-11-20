namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the MeasureGroups Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMeasureGroup))]
public interface IMeasureGroups // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Measure Group Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
