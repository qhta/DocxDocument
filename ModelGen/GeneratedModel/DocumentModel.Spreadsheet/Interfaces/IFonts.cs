namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Fonts Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFont))]
public interface IFonts // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Font Count
  /// </summary>
  public uint? Count { get ; set; }
  
  /// <summary>
  /// knownFonts, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? KnownFonts { get ; set; }
  
}
