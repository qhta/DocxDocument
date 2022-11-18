namespace DocumentModel.Spreadsheet;

/// <summary>
/// Volatile Dependency Type.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMain))]
public interface IVolatileType // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Type
  /// </summary>
  public VolatileDependency? Type { get ; set; }
  
}
