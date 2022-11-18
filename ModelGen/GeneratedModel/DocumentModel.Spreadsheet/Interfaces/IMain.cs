namespace DocumentModel.Spreadsheet;

/// <summary>
/// Main.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITopic))]
public interface IMain // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// First String
  /// </summary>
  public string? First { get ; set; }
  
}
