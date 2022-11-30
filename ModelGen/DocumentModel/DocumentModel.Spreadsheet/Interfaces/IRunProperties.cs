namespace DocumentModel.Spreadsheet;

/// <summary>
/// Run Properties.
/// </summary>
public interface IRunProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Boolean? Bold { get ; set; }
  
  public System.Boolean? Italic { get ; set; }
  
  public System.Boolean? Strike { get ; set; }
  
  public System.Boolean? Condense { get ; set; }
  
  public System.Boolean? Extend { get ; set; }
  
  public System.Boolean? Outline { get ; set; }
  
  public System.Boolean? Shadow { get ; set; }
  
  public DocumentModel.Spreadsheet.UnderlineKind? Underline { get ; set; }
  
  public DocumentModel.Spreadsheet.VerticalAlignmentRunKind? VerticalTextAlignment { get ; set; }
  
  public System.Double? FontSize { get ; set; }
  
  public DocumentModel.Spreadsheet.IColorType? Color { get ; set; }
  
  public System.String? RunFont { get ; set; }
  
  public System.Int32? FontFamily { get ; set; }
  
  public System.Int32? RunPropertyCharSet { get ; set; }
  
  public DocumentModel.Spreadsheet.FontSchemeKind? FontScheme { get ; set; }
  
}
