namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontFamily Class.
/// </summary>
public interface IFontFamily // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Font Family Value
  /// </summary>
  public FontFamilyValues? Val { get ; set; }
  
}
