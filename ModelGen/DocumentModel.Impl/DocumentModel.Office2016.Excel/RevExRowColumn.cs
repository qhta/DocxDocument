namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RevExRowColumn Class.
/// </summary>
public class RevExRowColumn: IRevExRowColumn
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
  /// eol, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Eol
  {
    get;
    set;
  }
  
  /// <summary>
  /// ref, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Ref
  {
    get;
    set;
  }
  
  /// <summary>
  /// action, this property is only available in Office 2016 and later.
  /// </summary>
  public RwColAction? Action
  {
    get;
    set;
  }
  
}
