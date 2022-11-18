namespace DocumentModel.Spreadsheet;

/// <summary>
/// Font Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IBold))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IItalic))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IStrike))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICondense))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtend))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IOutline))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IShadow))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFontCharSet))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColor))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFontFamilyNumbering))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFontName))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFontScheme))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFontSize))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IUnderline))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IVerticalTextAlignment))]
public interface IFont // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Bold.
  /// </summary>
  public DocumentModel.Spreadsheet.IBold? Bold { get ; set; }
  
  /// <summary>
  /// Italic.
  /// </summary>
  public DocumentModel.Spreadsheet.IItalic? Italic { get ; set; }
  
  /// <summary>
  /// Strike Through.
  /// </summary>
  public DocumentModel.Spreadsheet.IStrike? Strike { get ; set; }
  
  /// <summary>
  /// Condense.
  /// </summary>
  public ICondense? Condense { get ; set; }
  
  /// <summary>
  /// Extend.
  /// </summary>
  public IExtend? Extend { get ; set; }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public DocumentModel.Spreadsheet.IOutline? Outline { get ; set; }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public DocumentModel.Spreadsheet.IShadow? Shadow { get ; set; }
  
  /// <summary>
  /// Underline.
  /// </summary>
  public DocumentModel.Spreadsheet.IUnderline? Underline { get ; set; }
  
  /// <summary>
  /// Text Vertical Alignment.
  /// </summary>
  public DocumentModel.Spreadsheet.IVerticalTextAlignment? VerticalTextAlignment { get ; set; }
  
  /// <summary>
  /// Font Size.
  /// </summary>
  public DocumentModel.Spreadsheet.IFontSize? FontSize { get ; set; }
  
  /// <summary>
  /// Text Color.
  /// </summary>
  public DocumentModel.Spreadsheet.IColor? Color { get ; set; }
  
  /// <summary>
  /// Font Name.
  /// </summary>
  public IFontName? FontName { get ; set; }
  
  /// <summary>
  /// Font Family.
  /// </summary>
  public IFontFamilyNumbering? FontFamilyNumbering { get ; set; }
  
  /// <summary>
  /// Character Set.
  /// </summary>
  public DocumentModel.Spreadsheet.IFontCharSet? FontCharSet { get ; set; }
  
  /// <summary>
  /// Scheme.
  /// </summary>
  public DocumentModel.Spreadsheet.IFontScheme? FontScheme { get ; set; }
  
}
