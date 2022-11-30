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
  public System.String? OddHeaderXsdstring { get ; set; }
  
  /// <summary>
  /// OddFooterXsdstring.
  /// </summary>
  public System.String? OddFooterXsdstring { get ; set; }
  
  /// <summary>
  /// EvenHeaderXsdstring.
  /// </summary>
  public System.String? EvenHeaderXsdstring { get ; set; }
  
  /// <summary>
  /// EvenFooterXsdstring.
  /// </summary>
  public System.String? EvenFooterXsdstring { get ; set; }
  
  /// <summary>
  /// FirstHeaderXsdstring.
  /// </summary>
  public System.String? FirstHeaderXsdstring { get ; set; }
  
  /// <summary>
  /// FirstFooterXsdstring.
  /// </summary>
  public System.String? FirstFooterXsdstring { get ; set; }
  
}
