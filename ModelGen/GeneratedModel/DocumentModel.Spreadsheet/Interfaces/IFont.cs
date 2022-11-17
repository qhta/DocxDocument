namespace DocumentModel.Spreadsheet;

public interface IFont // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Spreadsheet.IBold? Bold { get ; set; }
  
  public DocumentModel.Spreadsheet.IItalic? Italic { get ; set; }
  
  public DocumentModel.Spreadsheet.IStrike? Strike { get ; set; }
  
  public ICondense? Condense { get ; set; }
  
  public IExtend? Extend { get ; set; }
  
  public DocumentModel.Spreadsheet.IOutline? Outline { get ; set; }
  
  public DocumentModel.Spreadsheet.IShadow? Shadow { get ; set; }
  
  public DocumentModel.Spreadsheet.IUnderline? Underline { get ; set; }
  
  public DocumentModel.Spreadsheet.IVerticalTextAlignment? VerticalTextAlignment { get ; set; }
  
  public DocumentModel.Spreadsheet.IFontSize? FontSize { get ; set; }
  
  public DocumentModel.Spreadsheet.IColor? Color { get ; set; }
  
  public IFontName? FontName { get ; set; }
  
  public IFontFamilyNumbering? FontFamilyNumbering { get ; set; }
  
  public DocumentModel.Spreadsheet.IFontCharSet? FontCharSet { get ; set; }
  
  public DocumentModel.Spreadsheet.IFontScheme? FontScheme { get ; set; }
  
}
