namespace DocumentModel.Drawing;

/// <summary>
/// Series Text.
/// </summary>
public interface ISeriesText // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// StringReference.
  /// </summary>
  public DocumentModel.Drawing.IStringReference? StringReference { get ; set; }
  
  /// <summary>
  /// NumericValue.
  /// </summary>
  public System.String? NumericValue { get ; set; }
  
}
