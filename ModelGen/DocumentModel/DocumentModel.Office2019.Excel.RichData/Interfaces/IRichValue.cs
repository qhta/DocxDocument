namespace DocumentModel.Office2019.Excel.RichData;

/// <summary>
/// Defines the RichValue Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.RichData.IRichValueFallback))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.RichData.IValue))]
public interface IRichValue // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// s, this property is only available in Office 2019 and later.
  /// </summary>
  public uint? S { get ; set; }
  
  /// <summary>
  /// RichValueFallback.
  /// </summary>
  public IRichValueFallback? RichValueFallback { get ; set; }
  
}
