namespace DocumentModel.Spreadsheet;

/// <summary>
/// External Cell Data.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IXstring))]
public interface IExternalCell // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public string? CellReference { get ; set; }
  
  /// <summary>
  /// Type
  /// </summary>
  public Cell? DataType { get ; set; }
  
  /// <summary>
  /// Value Metadata
  /// </summary>
  public uint? ValueMetaIndex { get ; set; }
  
  /// <summary>
  /// Value.
  /// </summary>
  public DocumentModel.Spreadsheet.IXstring? Xstring { get ; set; }
  
}
