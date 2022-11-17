namespace DocumentModel.Drawing.Charts;

public interface IHeaderFooter // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? AlignWithMargins { get ; set; }

  public bool? DifferentOddEven { get ; set; }

  public bool? DifferentFirst { get ; set; }

  public DocumentModel.Drawing.Charts.IOddHeader? OddHeader { get ; set; }

  public DocumentModel.Drawing.Charts.IOddFooter? OddFooter { get ; set; }

  public DocumentModel.Drawing.Charts.IEvenHeader? EvenHeader { get ; set; }

  public DocumentModel.Drawing.Charts.IEvenFooter? EvenFooter { get ; set; }

  public DocumentModel.Drawing.Charts.IFirstHeader? FirstHeader { get ; set; }

  public DocumentModel.Drawing.Charts.IFirstFooter? FirstFooter { get ; set; }

}
