namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Header and Footer.
/// </summary>
public partial class HeaderFooter
{
  
  /// <summary>
  ///   Align With Margins
  /// </summary>
  public Boolean? AlignWithMargins { get; set; }
  
  
  /// <summary>
  ///   Different Odd Even
  /// </summary>
  public Boolean? DifferentOddEven { get; set; }
  
  
  /// <summary>
  ///   Different First
  /// </summary>
  public Boolean? DifferentFirst { get; set; }
  
  
  /// <summary>
  ///   Odd Header.
  /// </summary>
  public DocumentModel.Drawings.Charts.OddHeader? OddHeader { get; set; }
  
  
  /// <summary>
  ///   Odd Footer.
  /// </summary>
  public DocumentModel.Drawings.Charts.OddFooter? OddFooter { get; set; }
  
  
  /// <summary>
  ///   Even Header.
  /// </summary>
  public DocumentModel.Drawings.Charts.EvenHeader? EvenHeader { get; set; }
  
  
  /// <summary>
  ///   Even Footer.
  /// </summary>
  public DocumentModel.Drawings.Charts.EvenFooter? EvenFooter { get; set; }
  
  
  /// <summary>
  ///   First Header.
  /// </summary>
  public DocumentModel.Drawings.Charts.FirstHeader? FirstHeader { get; set; }
  
  
  /// <summary>
  ///   First Footer.
  /// </summary>
  public DocumentModel.Drawings.Charts.FirstFooter? FirstFooter { get; set; }
  
}
