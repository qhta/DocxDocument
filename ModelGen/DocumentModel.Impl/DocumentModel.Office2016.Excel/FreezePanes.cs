namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the FreezePanes Class.
/// </summary>
public class FreezePanes: IFreezePanes
{
  /// <summary>
  /// sheetViewUid, this property is only available in Office 2016 and later.
  /// </summary>
  public string? SheetViewUid
  {
    get;
    set;
  }
  
}
