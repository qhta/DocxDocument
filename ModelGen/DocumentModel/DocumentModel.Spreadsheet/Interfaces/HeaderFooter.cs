namespace DocumentModel.Spreadsheet;

/// <summary>
/// Header Footer Settings.
/// </summary>
public interface HeaderFooter // : DocumentModel.BaseTypes.ModelElement
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
  public XstringType? OddHeader { get ; set; }
  
  /// <summary>
  /// Odd Page Footer.
  /// </summary>
  public XstringType? OddFooter { get ; set; }
  
  /// <summary>
  /// Even Page Header.
  /// </summary>
  public XstringType? EvenHeader { get ; set; }
  
  /// <summary>
  /// Even Page Footer.
  /// </summary>
  public XstringType? EvenFooter { get ; set; }
  
  /// <summary>
  /// First Page Header.
  /// </summary>
  public XstringType? FirstHeader { get ; set; }
  
  /// <summary>
  /// First Page Footer.
  /// </summary>
  public XstringType? FirstFooter { get ; set; }
  
}
