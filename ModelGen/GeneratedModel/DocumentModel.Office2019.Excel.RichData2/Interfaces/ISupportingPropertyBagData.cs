namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the SupportingPropertyBagData Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.RichData2.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.RichData2.ISupportingPropertyBag))]
public interface ISupportingPropertyBagData // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// count, this property is only available in Office 2019 and later.
  /// </summary>
  public uint? Count { get ; set; }
  
}
