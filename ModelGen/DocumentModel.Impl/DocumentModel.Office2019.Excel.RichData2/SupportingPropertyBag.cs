namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the SupportingPropertyBag Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.RichData2.ISupportingPropertyBagValue))]
public class SupportingPropertyBag: ISupportingPropertyBag
{
  /// <summary>
  /// s, this property is only available in Office 2019 and later.
  /// </summary>
  public uint? S
  {
    get;
    set;
  }
  
}
