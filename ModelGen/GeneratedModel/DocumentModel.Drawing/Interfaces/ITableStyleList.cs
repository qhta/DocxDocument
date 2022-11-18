namespace DocumentModel.Drawing;

/// <summary>
/// Table Style List.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableStyleEntry))]
public interface ITableStyleList // : DocumentFormat.OpenXml.TypedOpenXmlPartRootElement
{
  /// <summary>
  /// Default
  /// </summary>
  public string? Default { get ; set; }
  
}
