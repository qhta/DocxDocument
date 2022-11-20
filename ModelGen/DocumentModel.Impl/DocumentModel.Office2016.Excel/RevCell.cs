namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RevCell Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRstType))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IFFormula))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IXstring))]
public class RevCell: IRevCell
{
  /// <summary>
  /// t, this property is only available in Office 2016 and later.
  /// </summary>
  public CellValues? T
  {
    get;
    set;
  }
  
  /// <summary>
  /// nop, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Nop
  {
    get;
    set;
  }
  
  /// <summary>
  /// tick, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Tick
  {
    get;
    set;
  }
  
  /// <summary>
  /// rep, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? Rep
  {
    get;
    set;
  }
  
  /// <summary>
  /// FFormula.
  /// </summary>
  public IFFormula? FFormula
  {
    get;
    set;
  }
  
  /// <summary>
  /// Xstring.
  /// </summary>
  public DocumentModel.Office2016.Excel.IXstring? Xstring
  {
    get;
    set;
  }
  
  /// <summary>
  /// RstType.
  /// </summary>
  public DocumentModel.Office2016.Excel.IRstType? RstType
  {
    get;
    set;
  }
  
}
