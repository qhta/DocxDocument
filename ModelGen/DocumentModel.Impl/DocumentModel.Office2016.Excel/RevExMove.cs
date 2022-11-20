namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RevExMove Class.
/// </summary>
public class RevExMove: IRevExMove
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
  /// src, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Src
  {
    get;
    set;
  }
  
  /// <summary>
  /// dst, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Dst
  {
    get;
    set;
  }
  
  /// <summary>
  /// srcSh, this property is only available in Office 2016 and later.
  /// </summary>
  public string? SrcSh
  {
    get;
    set;
  }
  
}
