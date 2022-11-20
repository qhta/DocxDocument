namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Series Text.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IStringReference))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumericValue))]
public interface ISeriesText // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// StringReference.
  /// </summary>
  public IStringReference? StringReference { get ; set; }
  
  /// <summary>
  /// NumericValue.
  /// </summary>
  public DocumentModel.Drawing.Charts.INumericValue? NumericValue { get ; set; }
  
}
