namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the SupportingPropertyBagArrayData Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.RichData2.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.RichData2.ISupportingPropertyBagArray))]
public class SupportingPropertyBagArrayData: ISupportingPropertyBagArrayData
{
  /// <summary>
  /// count, this property is only available in Office 2019 and later.
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
