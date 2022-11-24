namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Header and Footer.
/// </summary>
public interface IHeaderFooter // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Align With Margins
  /// </summary>
  public Boolean? AlignWithMargins { get ; set; }
  
  /// <summary>
  /// Different Odd Even
  /// </summary>
  public Boolean? DifferentOddEven { get ; set; }
  
  /// <summary>
  /// Different First
  /// </summary>
  public Boolean? DifferentFirst { get ; set; }
  
  /// <summary>
  /// Odd Header.
  /// </summary>
  public IOddHeader? OddHeader { get ; set; }
  
  /// <summary>
  /// Odd Footer.
  /// </summary>
  public IOddFooter? OddFooter { get ; set; }
  
  /// <summary>
  /// Even Header.
  /// </summary>
  public IEvenHeader? EvenHeader { get ; set; }
  
  /// <summary>
  /// Even Footer.
  /// </summary>
  public IEvenFooter? EvenFooter { get ; set; }
  
  /// <summary>
  /// First Header.
  /// </summary>
  public IFirstHeader? FirstHeader { get ; set; }
  
  /// <summary>
  /// First Footer.
  /// </summary>
  public IFirstFooter? FirstFooter { get ; set; }
  
}
