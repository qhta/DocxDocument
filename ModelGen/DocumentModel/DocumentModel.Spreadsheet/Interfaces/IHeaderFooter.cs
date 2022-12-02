namespace DocumentModel.Spreadsheet;

/// <summary>
/// Header Footer Settings.
/// </summary>
public interface IHeaderFooter // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Different Odd Even Header Footer
  /// </summary>
  public Boolean? DifferentOddEven { get ; set; }
  
  /// <summary>
  /// Different First Page
  /// </summary>
  public Boolean? DifferentFirst { get ; set; }
  
  /// <summary>
  /// Scale Header and Footer With Document
  /// </summary>
  public Boolean? ScaleWithDoc { get ; set; }
  
  /// <summary>
  /// Align Margins
  /// </summary>
  public Boolean? AlignWithMargins { get ; set; }
  
  /// <summary>
  /// Odd Header.
  /// </summary>
  public IXstringType? OddHeader { get ; set; }
  
  /// <summary>
  /// Odd Page Footer.
  /// </summary>
  public IXstringType? OddFooter { get ; set; }
  
  /// <summary>
  /// Even Page Header.
  /// </summary>
  public IXstringType? EvenHeader { get ; set; }
  
  /// <summary>
  /// Even Page Footer.
  /// </summary>
  public IXstringType? EvenFooter { get ; set; }
  
  /// <summary>
  /// First Page Header.
  /// </summary>
  public IXstringType? FirstHeader { get ; set; }
  
  /// <summary>
  /// First Page Footer.
  /// </summary>
  public IXstringType? FirstFooter { get ; set; }
  
}
