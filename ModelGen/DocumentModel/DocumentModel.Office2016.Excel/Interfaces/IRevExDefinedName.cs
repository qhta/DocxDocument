namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RevExDefinedName Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IFormulaFormula))]
public interface IRevExDefinedName // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// rev, this property is only available in Office 2016 and later.
  /// </summary>
  public ulong? Rev { get ; set; }
  
  /// <summary>
  /// uid, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Uid { get ; set; }
  
  /// <summary>
  /// sh, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Sh { get ; set; }
  
  /// <summary>
  /// uidp, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Uidp { get ; set; }
  
  /// <summary>
  /// ctx, this property is only available in Office 2016 and later.
  /// </summary>
  public RevisionContext? Ctx { get ; set; }
  
  /// <summary>
  /// customView, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? CustomView { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// function, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Function { get ; set; }
  
  /// <summary>
  /// functionGroupId, this property is only available in Office 2016 and later.
  /// </summary>
  public byte? FunctionGroupId { get ; set; }
  
  /// <summary>
  /// shortcutKey, this property is only available in Office 2016 and later.
  /// </summary>
  public byte? ShortcutKey { get ; set; }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Hidden { get ; set; }
  
  /// <summary>
  /// customMenu, this property is only available in Office 2016 and later.
  /// </summary>
  public string? CustomMenu { get ; set; }
  
  /// <summary>
  /// description, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Description { get ; set; }
  
  /// <summary>
  /// help, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Help { get ; set; }
  
  /// <summary>
  /// statusBar, this property is only available in Office 2016 and later.
  /// </summary>
  public string? StatusBar { get ; set; }
  
  /// <summary>
  /// comment, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Comment { get ; set; }
  
  /// <summary>
  /// FormulaFormula.
  /// </summary>
  public IFormulaFormula? FormulaFormula { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2016.Excel.IExtensionList? ExtensionList { get ; set; }
  
}
