namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Series Text.
/// </summary>
public interface ISeriesText // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// StringReference.
  /// </summary>
  public IStringReference? StringReference { get ; set; }
  
  /// <summary>
  /// NumericValue.
  /// </summary>
  public INumericValue? NumericValue { get ; set; }
  
}
