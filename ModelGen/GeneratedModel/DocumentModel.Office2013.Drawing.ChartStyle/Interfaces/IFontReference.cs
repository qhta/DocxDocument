namespace DocumentModel.Office2013.Drawing.ChartStyle;

/// <summary>
/// Defines the FontReference Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IHslColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPresetColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISchemeColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRgbColorModelPercentage))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRgbColorModelHex))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISystemColor))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IStyleColor))]
public interface IFontReference // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  public FontCollectionIndex? Index { get ; set; }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public List<string>? Modifiers { get ; set; }
  
}
