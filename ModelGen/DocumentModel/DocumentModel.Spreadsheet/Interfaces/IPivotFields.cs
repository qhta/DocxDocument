namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFields Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotField))]
public interface IPivotFields // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
