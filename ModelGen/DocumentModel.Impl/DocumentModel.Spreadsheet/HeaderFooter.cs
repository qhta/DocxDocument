namespace DocumentModel.Spreadsheet;

/// <summary>
/// Header Footer Settings.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IOddHeader))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IOddFooter))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IEvenHeader))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IEvenFooter))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFirstHeader))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFirstFooter))]
public class HeaderFooter: IHeaderFooter
{
  /// <summary>
  /// Different Odd Even Header Footer
  /// </summary>
  public bool? DifferentOddEven
  {
    get;
    set;
  }
  
  /// <summary>
  /// Different First Page
  /// </summary>
  public bool? DifferentFirst
  {
    get;
    set;
  }
  
  /// <summary>
  /// Scale Header and Footer With Document
  /// </summary>
  public bool? ScaleWithDoc
  {
    get;
    set;
  }
  
  /// <summary>
  /// Align Margins
  /// </summary>
  public bool? AlignWithMargins
  {
    get;
    set;
  }
  
  /// <summary>
  /// Odd Header.
  /// </summary>
  public DocumentModel.Spreadsheet.IOddHeader? OddHeader
  {
    get;
    set;
  }
  
  /// <summary>
  /// Odd Page Footer.
  /// </summary>
  public DocumentModel.Spreadsheet.IOddFooter? OddFooter
  {
    get;
    set;
  }
  
  /// <summary>
  /// Even Page Header.
  /// </summary>
  public DocumentModel.Spreadsheet.IEvenHeader? EvenHeader
  {
    get;
    set;
  }
  
  /// <summary>
  /// Even Page Footer.
  /// </summary>
  public DocumentModel.Spreadsheet.IEvenFooter? EvenFooter
  {
    get;
    set;
  }
  
  /// <summary>
  /// First Page Header.
  /// </summary>
  public DocumentModel.Spreadsheet.IFirstHeader? FirstHeader
  {
    get;
    set;
  }
  
  /// <summary>
  /// First Page Footer.
  /// </summary>
  public DocumentModel.Spreadsheet.IFirstFooter? FirstFooter
  {
    get;
    set;
  }
  
}
