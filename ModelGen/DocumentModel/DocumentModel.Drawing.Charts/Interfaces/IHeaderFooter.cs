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
  public DocumentModel.BaseTypes.ModelElement? OddHeader { get ; set; }
  
  /// <summary>
  /// Odd Footer.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? OddFooter { get ; set; }
  
  /// <summary>
  /// Even Header.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EvenHeader { get ; set; }
  
  /// <summary>
  /// Even Footer.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EvenFooter { get ; set; }
  
  /// <summary>
  /// First Header.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? FirstHeader { get ; set; }
  
  /// <summary>
  /// First Footer.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? FirstFooter { get ; set; }
  
}
