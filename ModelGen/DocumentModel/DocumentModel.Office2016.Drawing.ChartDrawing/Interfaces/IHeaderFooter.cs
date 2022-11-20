namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the HeaderFooter Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IOddHeaderXsdstring))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IOddFooterXsdstring))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IEvenHeaderXsdstring))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IEvenFooterXsdstring))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IFirstHeaderXsdstring))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IFirstFooterXsdstring))]
public interface IHeaderFooter // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// alignWithMargins, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? AlignWithMargins { get ; set; }
  
  /// <summary>
  /// differentOddEven, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? DifferentOddEven { get ; set; }
  
  /// <summary>
  /// differentFirst, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? DifferentFirst { get ; set; }
  
  /// <summary>
  /// OddHeaderXsdstring.
  /// </summary>
  public IOddHeaderXsdstring? OddHeaderXsdstring { get ; set; }
  
  /// <summary>
  /// OddFooterXsdstring.
  /// </summary>
  public IOddFooterXsdstring? OddFooterXsdstring { get ; set; }
  
  /// <summary>
  /// EvenHeaderXsdstring.
  /// </summary>
  public IEvenHeaderXsdstring? EvenHeaderXsdstring { get ; set; }
  
  /// <summary>
  /// EvenFooterXsdstring.
  /// </summary>
  public IEvenFooterXsdstring? EvenFooterXsdstring { get ; set; }
  
  /// <summary>
  /// FirstHeaderXsdstring.
  /// </summary>
  public IFirstHeaderXsdstring? FirstHeaderXsdstring { get ; set; }
  
  /// <summary>
  /// FirstFooterXsdstring.
  /// </summary>
  public IFirstFooterXsdstring? FirstFooterXsdstring { get ; set; }
  
}
