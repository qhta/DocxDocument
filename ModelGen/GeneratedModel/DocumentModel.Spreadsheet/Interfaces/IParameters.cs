namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Parameters Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IParameter))]
public interface IParameters // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Parameter Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
