namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RevGroup Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRevExChangeCell))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRevExChgObj))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRevExDefinedName))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRevExDelObj))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRevExFormatting))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRevExFuture))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRevExMove))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRevExRowColumn))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRevExSheetOp))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRevExTrimmed))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRevExUnsupported))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRevisionList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRevListAutoExpandRw))]
public interface IRevGroup // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  
}
