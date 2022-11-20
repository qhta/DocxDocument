namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Member Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMemberProperty))]
public interface IMemberProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// OLAP Member Properties Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
