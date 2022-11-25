namespace DocumentModel.Spreadsheet;

/// <summary>
/// Font Properties.
/// </summary>
public interface IFont // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Bold.
  /// </summary>
  public System.Boolean? Bold { get ; set; }
  
  /// <summary>
  /// Italic.
  /// </summary>
  public System.Boolean? Italic { get ; set; }
  
  /// <summary>
  /// Strike Through.
  /// </summary>
  public System.Boolean? Strike { get ; set; }
  
  /// <summary>
  /// Condense.
  /// </summary>
  public System.Boolean? Condense { get ; set; }
  
  /// <summary>
  /// Extend.
  /// </summary>
  public System.Boolean? Extend { get ; set; }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public System.Boolean? Outline { get ; set; }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public System.Boolean? Shadow { get ; set; }
  
  /// <summary>
  /// Underline.
  /// </summary>
  public DocumentModel.Spreadsheet.UnderlineKind? Underline { get ; set; }
  
  /// <summary>
  /// Text Vertical Alignment.
  /// </summary>
  public DocumentModel.Spreadsheet.VerticalAlignmentRunKind? VerticalTextAlignment { get ; set; }
  
  /// <summary>
  /// Font Size.
  /// </summary>
  public System.Double? FontSize { get ; set; }
  
  /// <summary>
  /// Text Color.
  /// </summary>
  public DocumentModel.Spreadsheet.IColorType? Color { get ; set; }
  
  /// <summary>
  /// Font Name.
  /// </summary>
  public System.String? FontName { get ; set; }
  
  /// <summary>
  /// Font Family.
  /// </summary>
  public System.Int32? FontFamilyNumbering { get ; set; }
  
  /// <summary>
  /// Character Set.
  /// </summary>
  public System.Int32? FontCharSet { get ; set; }
  
  /// <summary>
  /// Scheme.
  /// </summary>
  public DocumentModel.Spreadsheet.FontSchemeKind? FontScheme { get ; set; }
  
}
