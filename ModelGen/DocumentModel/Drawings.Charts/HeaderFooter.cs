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
  public DMDC.OddHeader? OddHeader { get; set; }
  
  
  /// <summary>
  ///   Odd Footer.
  /// </summary>
  public DMDC.OddFooter? OddFooter { get; set; }
  
  
  /// <summary>
  ///   Even Header.
  /// </summary>
  public DMDC.EvenHeader? EvenHeader { get; set; }
  
  
  /// <summary>
  ///   Even Footer.
  /// </summary>
  public DMDC.EvenFooter? EvenFooter { get; set; }
  
  
  /// <summary>
  ///   First Header.
  /// </summary>
  public DMDC.FirstHeader? FirstHeader { get; set; }
  
  
  /// <summary>
  ///   First Footer.
  /// </summary>
  public DMDC.FirstFooter? FirstFooter { get; set; }
  
}
