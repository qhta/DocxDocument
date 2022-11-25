namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the HeaderFooter Class.
/// </summary>
public interface IHeaderFooter // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// alignWithMargins, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Boolean? AlignWithMargins { get ; set; }
  
  /// <summary>
  /// differentOddEven, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Boolean? DifferentOddEven { get ; set; }
  
  /// <summary>
  /// differentFirst, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Boolean? DifferentFirst { get ; set; }
  
  /// <summary>
  /// OddHeaderXsdstring.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? OddHeaderXsdstring { get ; set; }
  
  /// <summary>
  /// OddFooterXsdstring.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? OddFooterXsdstring { get ; set; }
  
  /// <summary>
  /// EvenHeaderXsdstring.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EvenHeaderXsdstring { get ; set; }
  
  /// <summary>
  /// EvenFooterXsdstring.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EvenFooterXsdstring { get ; set; }
  
  /// <summary>
  /// FirstHeaderXsdstring.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? FirstHeaderXsdstring { get ; set; }
  
  /// <summary>
  /// FirstFooterXsdstring.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? FirstFooterXsdstring { get ; set; }
  
}
