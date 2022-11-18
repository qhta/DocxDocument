namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RevExFormatting Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IDifferentialFormatType))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IExtensionList))]
public interface IRevExFormatting // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  /// numFmtId, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? NumFmtId { get ; set; }
  
  /// <summary>
  /// xfDxf, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? XfDxf { get ; set; }
  
  /// <summary>
  /// style, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Style { get ; set; }
  
  /// <summary>
  /// sqref, this property is only available in Office 2016 and later.
  /// </summary>
  public List<string>? Sqref { get ; set; }
  
  /// <summary>
  /// start, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? Start { get ; set; }
  
  /// <summary>
  /// length, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? Length { get ; set; }
  
  /// <summary>
  /// styleUid, this property is only available in Office 2016 and later.
  /// </summary>
  public string? StyleUid { get ; set; }
  
  /// <summary>
  /// fBlankCell, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? FBlankCell { get ; set; }
  
  /// <summary>
  /// applyNumberFormat, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? ApplyNumberFormat { get ; set; }
  
  /// <summary>
  /// applyFont, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? ApplyFont { get ; set; }
  
  /// <summary>
  /// applyFill, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? ApplyFill { get ; set; }
  
  /// <summary>
  /// applyBorder, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? ApplyBorder { get ; set; }
  
  /// <summary>
  /// applyAlignment, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? ApplyAlignment { get ; set; }
  
  /// <summary>
  /// applyProtection, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? ApplyProtection { get ; set; }
  
  /// <summary>
  /// DifferentialFormatType.
  /// </summary>
  public DocumentModel.Office2016.Excel.IDifferentialFormatType? DifferentialFormatType { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2016.Excel.IExtensionList? ExtensionList { get ; set; }
  
}
