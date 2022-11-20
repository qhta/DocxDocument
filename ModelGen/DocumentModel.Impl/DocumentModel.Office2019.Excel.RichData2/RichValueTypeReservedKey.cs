namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the RichValueTypeReservedKey Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.RichData2.IRichValueTypeReservedKeyFlag))]
public class RichValueTypeReservedKey: IRichValueTypeReservedKey
{
  /// <summary>
  /// name, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
}
