namespace DocumentModel.Spreadsheet;

public interface IHeaderFooter // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? DifferentOddEven { get ; set; }

  public bool? DifferentFirst { get ; set; }

  public bool? ScaleWithDoc { get ; set; }

  public bool? AlignWithMargins { get ; set; }

  public DocumentModel.Spreadsheet.IOddHeader? OddHeader { get ; set; }

  public DocumentModel.Spreadsheet.IOddFooter? OddFooter { get ; set; }

  public DocumentModel.Spreadsheet.IEvenHeader? EvenHeader { get ; set; }

  public DocumentModel.Spreadsheet.IEvenFooter? EvenFooter { get ; set; }

  public DocumentModel.Spreadsheet.IFirstHeader? FirstHeader { get ; set; }

  public DocumentModel.Spreadsheet.IFirstFooter? FirstFooter { get ; set; }

}
