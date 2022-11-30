namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the FormControlProperties Class.
/// </summary>
public interface IFormControlProperties // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// objectType, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Excel.ObjectKind? ObjectType { get ; set; }
  
  /// <summary>
  /// checked, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Excel.CheckedKind? Checked { get ; set; }
  
  /// <summary>
  /// colored, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Colored { get ; set; }
  
  /// <summary>
  /// dropLines, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? DropLines { get ; set; }
  
  /// <summary>
  /// dropStyle, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Excel.DropStyleKind? DropStyle { get ; set; }
  
  /// <summary>
  /// dx, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? ScrollBarWidth { get ; set; }
  
  /// <summary>
  /// firstButton, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? FirstButton { get ; set; }
  
  /// <summary>
  /// fmlaGroup, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? FmlaGroup { get ; set; }
  
  /// <summary>
  /// fmlaLink, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? FmlaLink { get ; set; }
  
  /// <summary>
  /// fmlaRange, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? FmlaRange { get ; set; }
  
  /// <summary>
  /// fmlaTxbx, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? FmlaTextbox { get ; set; }
  
  /// <summary>
  /// horiz, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Horizontal { get ; set; }
  
  /// <summary>
  /// inc, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? Incremental { get ; set; }
  
  /// <summary>
  /// justLastX, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? JustLastX { get ; set; }
  
  /// <summary>
  /// lockText, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? LockText { get ; set; }
  
  /// <summary>
  /// max, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? Max { get ; set; }
  
  /// <summary>
  /// min, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? Min { get ; set; }
  
  /// <summary>
  /// multiSel, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? MultipleSelection { get ; set; }
  
  /// <summary>
  /// noThreeD, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? NoThreeD { get ; set; }
  
  /// <summary>
  /// noThreeD2, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? NoThreeD2 { get ; set; }
  
  /// <summary>
  /// page, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? Page { get ; set; }
  
  /// <summary>
  /// sel, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? Selected { get ; set; }
  
  /// <summary>
  /// seltype, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Excel.SelectionKind? SelectionType { get ; set; }
  
  /// <summary>
  /// textHAlign, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Excel.TextHorizontalAlignmentKind? TextHorizontalAlign { get ; set; }
  
  /// <summary>
  /// textVAlign, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Excel.TextVerticalAlignmentKind? TextVerticalAlign { get ; set; }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? Val { get ; set; }
  
  /// <summary>
  /// widthMin, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? MinimumWidth { get ; set; }
  
  /// <summary>
  /// editVal, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Excel.EditValidationKind? EditVal { get ; set; }
  
  /// <summary>
  /// multiLine, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? MultipleLines { get ; set; }
  
  /// <summary>
  /// verticalBar, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? VerticalBar { get ; set; }
  
  /// <summary>
  /// passwordEdit, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? PasswordEdit { get ; set; }
  
  /// <summary>
  /// ListItems.
  /// </summary>
  public DocumentModel.Office2010.Excel.IListItems? ListItems { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2010.Excel.IExtensionList? ExtensionList { get ; set; }
  
}
