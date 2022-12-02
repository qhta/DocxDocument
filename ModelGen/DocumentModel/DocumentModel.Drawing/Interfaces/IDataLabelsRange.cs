namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DataLabelsRange Class.
/// </summary>
public interface IDataLabelsRange // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula { get ; set; }
  
  /// <summary>
  /// DataLabelsRangeChache.
  /// </summary>
  public IDataLabelsRangeChache? DataLabelsRangeChache { get ; set; }
  
}
