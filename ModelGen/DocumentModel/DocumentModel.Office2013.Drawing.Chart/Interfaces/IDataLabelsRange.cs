namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the DataLabelsRange Class.
/// </summary>
public interface IDataLabelsRange // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public IFormula? Formula { get ; set; }
  
  /// <summary>
  /// DataLabelsRangeChache.
  /// </summary>
  public IDataLabelsRangeChache? DataLabelsRangeChache { get ; set; }
  
}
