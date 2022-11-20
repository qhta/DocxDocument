namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Header and Footer.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IOddHeader))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IOddFooter))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IEvenHeader))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IEvenFooter))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IFirstHeader))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IFirstFooter))]
public interface IHeaderFooter // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Align With Margins
  /// </summary>
  public bool? AlignWithMargins { get ; set; }
  
  /// <summary>
  /// Different Odd Even
  /// </summary>
  public bool? DifferentOddEven { get ; set; }
  
  /// <summary>
  /// Different First
  /// </summary>
  public bool? DifferentFirst { get ; set; }
  
  /// <summary>
  /// Odd Header.
  /// </summary>
  public DocumentModel.Drawing.Charts.IOddHeader? OddHeader { get ; set; }
  
  /// <summary>
  /// Odd Footer.
  /// </summary>
  public DocumentModel.Drawing.Charts.IOddFooter? OddFooter { get ; set; }
  
  /// <summary>
  /// Even Header.
  /// </summary>
  public DocumentModel.Drawing.Charts.IEvenHeader? EvenHeader { get ; set; }
  
  /// <summary>
  /// Even Footer.
  /// </summary>
  public DocumentModel.Drawing.Charts.IEvenFooter? EvenFooter { get ; set; }
  
  /// <summary>
  /// First Header.
  /// </summary>
  public DocumentModel.Drawing.Charts.IFirstHeader? FirstHeader { get ; set; }
  
  /// <summary>
  /// First Footer.
  /// </summary>
  public DocumentModel.Drawing.Charts.IFirstFooter? FirstFooter { get ; set; }
  
}
