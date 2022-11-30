namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Header and Footer.
/// </summary>
public interface IHeaderFooter // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Align With Margins
  /// </summary>
  public System.Boolean? AlignWithMargins { get ; set; }
  
  /// <summary>
  /// Different Odd Even
  /// </summary>
  public System.Boolean? DifferentOddEven { get ; set; }
  
  /// <summary>
  /// Different First
  /// </summary>
  public System.Boolean? DifferentFirst { get ; set; }
  
  /// <summary>
  /// Odd Header.
  /// </summary>
  public System.String? OddHeader { get ; set; }
  
  /// <summary>
  /// Odd Footer.
  /// </summary>
  public System.String? OddFooter { get ; set; }
  
  /// <summary>
  /// Even Header.
  /// </summary>
  public System.String? EvenHeader { get ; set; }
  
  /// <summary>
  /// Even Footer.
  /// </summary>
  public System.String? EvenFooter { get ; set; }
  
  /// <summary>
  /// First Header.
  /// </summary>
  public System.String? FirstHeader { get ; set; }
  
  /// <summary>
  /// First Footer.
  /// </summary>
  public System.String? FirstFooter { get ; set; }
  
}
