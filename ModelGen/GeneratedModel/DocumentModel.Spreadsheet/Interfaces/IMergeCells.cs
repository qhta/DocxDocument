namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the MergeCells Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMergeCell))]
public interface IMergeCells // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
