namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IHeaderFooter // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? AlignWithMargins { get ; set; }

  public bool? DifferentOddEven { get ; set; }

  public bool? DifferentFirst { get ; set; }

  public IOddHeaderXsdstring? OddHeaderXsdstring { get ; set; }

  public IOddFooterXsdstring? OddFooterXsdstring { get ; set; }

  public IEvenHeaderXsdstring? EvenHeaderXsdstring { get ; set; }

  public IEvenFooterXsdstring? EvenFooterXsdstring { get ; set; }

  public IFirstHeaderXsdstring? FirstHeaderXsdstring { get ; set; }

  public IFirstFooterXsdstring? FirstFooterXsdstring { get ; set; }

}
