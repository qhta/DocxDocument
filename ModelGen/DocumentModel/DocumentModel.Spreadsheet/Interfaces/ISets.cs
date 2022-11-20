namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sets.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITupleSet))]
public interface ISets // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Tuple Set Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
