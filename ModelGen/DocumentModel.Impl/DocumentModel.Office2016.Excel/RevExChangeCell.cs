namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RevExChangeCell Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IChangeCellSubEdit))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRevCell))]
public class RevExChangeCell: IRevExChangeCell
{
  /// <summary>
  /// listUid, this property is only available in Office 2016 and later.
  /// </summary>
  public string? ListUid
  {
    get;
    set;
  }
  
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
  /// r, this property is only available in Office 2016 and later.
  /// </summary>
  public string? R
  {
    get;
    set;
  }
  
  /// <summary>
  /// t, this property is only available in Office 2016 and later.
  /// </summary>
  public FillType? T
  {
    get;
    set;
  }
  
  /// <summary>
  /// x, this property is only available in Office 2016 and later.
  /// </summary>
  public FillTypeExt? X
  {
    get;
    set;
  }
  
  /// <summary>
  /// w, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? W
  {
    get;
    set;
  }
  
}
