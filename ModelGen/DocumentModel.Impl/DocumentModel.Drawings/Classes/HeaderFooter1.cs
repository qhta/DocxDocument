namespace DocumentModel.Drawings;

/// <summary>
/// Header and Footer.
/// </summary>
public class HeaderFooter1Impl: ModelElementImpl, HeaderFooter1
{
  public DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Align With Margins
  /// </summary>
  public Boolean? AlignWithMargins
  {
    get;
    set;
  }
  
  /// <summary>
  /// Different Odd Even
  /// </summary>
  public Boolean? DifferentOddEven
  {
    get;
    set;
  }
  
  /// <summary>
  /// Different First
  /// </summary>
  public Boolean? DifferentFirst
  {
    get;
    set;
  }
  
  /// <summary>
  /// Odd Header.
  /// </summary>
  public String? OddHeader
  {
    get;
    set;
  }
  
  /// <summary>
  /// Odd Footer.
  /// </summary>
  public String? OddFooter
  {
    get;
    set;
  }
  
  /// <summary>
  /// Even Header.
  /// </summary>
  public String? EvenHeader
  {
    get;
    set;
  }
  
  /// <summary>
  /// Even Footer.
  /// </summary>
  public String? EvenFooter
  {
    get;
    set;
  }
  
  /// <summary>
  /// First Header.
  /// </summary>
  public String? FirstHeader
  {
    get;
    set;
  }
  
  /// <summary>
  /// First Footer.
  /// </summary>
  public String? FirstFooter
  {
    get;
    set;
  }
  
}
