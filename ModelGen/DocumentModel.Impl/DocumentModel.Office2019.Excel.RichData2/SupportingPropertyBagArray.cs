namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the SupportingPropertyBagArray Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.RichData2.ISupportingPropertyBagArrayValue))]
public class SupportingPropertyBagArray: ISupportingPropertyBagArray
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
