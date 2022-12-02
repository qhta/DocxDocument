namespace DocumentModel.Drawing;

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
  public DocumentModel.Drawing.IDataLabelsRangeChache? DataLabelsRangeChache { get ; set; }
  
}
