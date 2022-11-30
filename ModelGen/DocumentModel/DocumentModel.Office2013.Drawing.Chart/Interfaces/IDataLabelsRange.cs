namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the DataLabelsRange Class.
/// </summary>
public interface IDataLabelsRange // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public System.String? Formula { get ; set; }
  
  /// <summary>
  /// DataLabelsRangeChache.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IDataLabelsRangeChache? DataLabelsRangeChache { get ; set; }
  
}
