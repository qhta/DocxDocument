namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the CustomRichFilters Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.RichData2.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.RichData2.ICustomRichFilter))]
public class CustomRichFilters: ICustomRichFilters
{
  /// <summary>
  /// and, this property is only available in Office 2019 and later.
  /// </summary>
  public bool? And
  {
    get;
    set;
  }
  
}
