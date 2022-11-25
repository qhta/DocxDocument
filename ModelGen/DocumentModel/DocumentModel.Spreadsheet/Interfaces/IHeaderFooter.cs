namespace DocumentModel.Spreadsheet;

/// <summary>
/// Header Footer Settings.
/// </summary>
public interface IHeaderFooter // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Different Odd Even Header Footer
  /// </summary>
  public System.Boolean? DifferentOddEven { get ; set; }
  
  /// <summary>
  /// Different First Page
  /// </summary>
  public System.Boolean? DifferentFirst { get ; set; }
  
  /// <summary>
  /// Scale Header and Footer With Document
  /// </summary>
  public System.Boolean? ScaleWithDoc { get ; set; }
  
  /// <summary>
  /// Align Margins
  /// </summary>
  public System.Boolean? AlignWithMargins { get ; set; }
  
  /// <summary>
  /// Odd Header.
  /// </summary>
  public DocumentModel.Spreadsheet.IXstringType? OddHeader { get ; set; }
  
  /// <summary>
  /// Odd Page Footer.
  /// </summary>
  public DocumentModel.Spreadsheet.IXstringType? OddFooter { get ; set; }
  
  /// <summary>
  /// Even Page Header.
  /// </summary>
  public DocumentModel.Spreadsheet.IXstringType? EvenHeader { get ; set; }
  
  /// <summary>
  /// Even Page Footer.
  /// </summary>
  public DocumentModel.Spreadsheet.IXstringType? EvenFooter { get ; set; }
  
  /// <summary>
  /// First Page Header.
  /// </summary>
  public DocumentModel.Spreadsheet.IXstringType? FirstHeader { get ; set; }
  
  /// <summary>
  /// First Page Footer.
  /// </summary>
  public DocumentModel.Spreadsheet.IXstringType? FirstFooter { get ; set; }
  
}
