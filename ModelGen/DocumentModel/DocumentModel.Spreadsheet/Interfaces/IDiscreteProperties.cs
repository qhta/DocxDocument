namespace DocumentModel.Spreadsheet;

/// <summary>
/// Discrete Grouping Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFieldItem))]
public interface IDiscreteProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Mapping Index Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
