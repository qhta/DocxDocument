namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RevListAutoExpandRw Class.
/// </summary>
public interface IRevListAutoExpandRw // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
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
  /// refAdded, this property is only available in Office 2016 and later.
  /// </summary>
  public string? RefAdded { get ; set; }
  
  /// <summary>
  /// listGuid, this property is only available in Office 2016 and later.
  /// </summary>
  public string? ListGuid { get ; set; }
  
}
