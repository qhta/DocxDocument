namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RevisionList Class.
/// </summary>
public interface IRevisionList // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
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
  /// Data, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Data { get ; set; }
  
  /// <summary>
  /// Formatting, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Formatting { get ; set; }
  
  /// <summary>
  /// RangeBased, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? RangeBased { get ; set; }
  
  /// <summary>
  /// Fake, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Fake { get ; set; }
  
  /// <summary>
  /// ref, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Ref { get ; set; }
  
  /// <summary>
  /// Headers, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Headers { get ; set; }
  
  /// <summary>
  /// InsDelHeaders, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? InsDelHeaders { get ; set; }
  
  /// <summary>
  /// rId, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? RId { get ; set; }
  
}
