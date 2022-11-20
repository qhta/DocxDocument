namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the Array Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.RichData2.IArrayValue))]
public class Array: IArray
{
  /// <summary>
  /// r, this property is only available in Office 2019 and later.
  /// </summary>
  public uint? R
  {
    get;
    set;
  }
  
  /// <summary>
  /// c, this property is only available in Office 2019 and later.
  /// </summary>
  public uint? C
  {
    get;
    set;
  }
  
}
