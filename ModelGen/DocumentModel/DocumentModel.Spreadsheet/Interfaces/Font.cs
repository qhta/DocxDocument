namespace DocumentModel.Spreadsheet;

/// <summary>
/// Font Properties.
/// </summary>
public interface Font // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Bold.
  /// </summary>
  public Boolean? Bold { get ; set; }
  
  /// <summary>
  /// Italic.
  /// </summary>
  public Boolean? Italic { get ; set; }
  
  /// <summary>
  /// Strike Through.
  /// </summary>
  public Boolean? Strike { get ; set; }
  
  /// <summary>
  /// Condense.
  /// </summary>
  public Boolean? Condense { get ; set; }
  
  /// <summary>
  /// Extend.
  /// </summary>
  public Boolean? Extend { get ; set; }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public Boolean? Outline { get ; set; }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public Boolean? Shadow { get ; set; }
  
  /// <summary>
  /// Underline.
  /// </summary>
  public UnderlineKind? Underline { get ; set; }
  
  /// <summary>
  /// Text Vertical Alignment.
  /// </summary>
  public VerticalAlignmentRunKind? VerticalTextAlignment { get ; set; }
  
  /// <summary>
  /// Font Size.
  /// </summary>
  public Double? FontSize { get ; set; }
  
  /// <summary>
  /// Text Color.
  /// </summary>
  public ColorType? Color { get ; set; }
  
  /// <summary>
  /// Font Name.
  /// </summary>
  public String? FontName { get ; set; }
  
  /// <summary>
  /// Font Family.
  /// </summary>
  public Int32? FontFamilyNumbering { get ; set; }
  
  /// <summary>
  /// Character Set.
  /// </summary>
  public Int32? FontCharSet { get ; set; }
  
  /// <summary>
  /// Scheme.
  /// </summary>
  public FontSchemeKind? FontScheme { get ; set; }
  
}
