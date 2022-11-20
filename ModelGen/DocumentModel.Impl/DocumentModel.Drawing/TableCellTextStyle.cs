namespace DocumentModel.Drawing;

/// <summary>
/// Table Cell Text Style.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IFonts))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IFontReference))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IHslColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPresetColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISchemeColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRgbColorModelPercentage))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRgbColorModelHex))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISystemColor))]
public class TableCellTextStyle: ITableCellTextStyle
{
  /// <summary>
  /// Bold
  /// </summary>
  public BooleanStyleValues? Bold
  {
    get;
    set;
  }
  
  /// <summary>
  /// Italic
  /// </summary>
  public BooleanStyleValues? Italic
  {
    get;
    set;
  }
  
}
