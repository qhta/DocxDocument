namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Header and Footer.
/// </summary>
public class HeaderFooter: ModelElement
{
  /// <summary>
  ///   Align With Margins
  /// </summary>
  public bool? AlignWithMargins { get; set; }
  /// <summary>
  ///   Different Odd Even
  /// </summary>
  public bool? DifferentOddEven { get; set; }
  /// <summary>
  ///   Different First
  /// </summary>
  public bool? DifferentFirst { get; set; }
  /// <summary>
  ///   Odd Header.
  /// </summary>
  public string? OddHeader { get; set; }
  /// <summary>
  ///   Odd Footer.
  /// </summary>
  public string? OddFooter { get; set; }
  /// <summary>
  ///   Even Header.
  /// </summary>
  public string? EvenHeader { get; set; }
  /// <summary>
  ///   Even Footer.
  /// </summary>
  public string? EvenFooter { get; set; }
  /// <summary>
  ///   First Header.
  /// </summary>
  public string? FirstHeader { get; set; }
  /// <summary>
  ///   First Footer.
  /// </summary>
  public string? FirstFooter { get; set; }
}