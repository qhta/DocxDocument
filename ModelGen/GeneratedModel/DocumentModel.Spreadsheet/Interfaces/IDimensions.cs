namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Dimensions Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDimension))]
public interface IDimensions // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// OLAP Dimensions Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
