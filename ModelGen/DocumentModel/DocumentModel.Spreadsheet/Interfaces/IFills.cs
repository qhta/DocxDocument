namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Fills Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFill))]
public interface IFills // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Fill Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
