namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RevExSheetOp Class.
/// </summary>
public class RevExSheetOp: IRevExSheetOp
{
  /// <summary>
  /// rev, this property is only available in Office 2016 and later.
  /// </summary>
  public ulong? Rev
  {
    get;
    set;
  }
  
  /// <summary>
  /// uid, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Uid
  {
    get;
    set;
  }
  
  /// <summary>
  /// sh, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Sh
  {
    get;
    set;
  }
  
  /// <summary>
  /// uidp, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Uidp
  {
    get;
    set;
  }
  
  /// <summary>
  /// ctx, this property is only available in Office 2016 and later.
  /// </summary>
  public RevisionContext? Ctx
  {
    get;
    set;
  }
  
  /// <summary>
  /// op, this property is only available in Office 2016 and later.
  /// </summary>
  public SheetOp? Op
  {
    get;
    set;
  }
  
  /// <summary>
  /// name, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// idOrig, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? IdOrig
  {
    get;
    set;
  }
  
  /// <summary>
  /// idNew, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? IdNew
  {
    get;
    set;
  }
  
}
