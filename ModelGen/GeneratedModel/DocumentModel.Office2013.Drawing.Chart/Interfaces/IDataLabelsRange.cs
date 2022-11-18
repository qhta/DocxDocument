namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the DataLabelsRange Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IDataLabelsRangeChache))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFormula))]
public interface IDataLabelsRange // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IFormula? Formula { get ; set; }
  
  /// <summary>
  /// DataLabelsRangeChache.
  /// </summary>
  public IDataLabelsRangeChache? DataLabelsRangeChache { get ; set; }
  
}
