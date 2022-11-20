namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RevExChgObj Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRevisionState))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRevisionStateLink))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IStateBasedHeader))]
public interface IRevExChgObj // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  /// StateBasedHeader.
  /// </summary>
  public IStateBasedHeader? StateBasedHeader { get ; set; }
  
}
