namespace DocumentModel.Office2013.Drawing.ChartStyle;

/// <summary>
/// Defines the ColorStyle Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IHslColor))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPresetColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISchemeColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRgbColorModelPercentage))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRgbColorModelHex))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISystemColor))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IColorStyleVariation))]
public interface IColorStyle // : DocumentFormat.OpenXml.TypedOpenXmlPartRootElement
{
  /// <summary>
  /// meth, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Method { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Id { get ; set; }
  
}
