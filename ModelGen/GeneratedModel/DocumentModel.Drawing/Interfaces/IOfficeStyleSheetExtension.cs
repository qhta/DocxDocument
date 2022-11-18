namespace DocumentModel.Drawing;

/// <summary>
/// Defines the OfficeStyleSheetExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Theme.IThemeFamily))]
public interface IOfficeStyleSheetExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
