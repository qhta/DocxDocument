namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the OleItem Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IDdeValues))]
public interface IOleItem // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// icon, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Icon { get ; set; }
  
  /// <summary>
  /// advise, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Advise { get ; set; }
  
  /// <summary>
  /// preferPic, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? PreferPicture { get ; set; }
  
  /// <summary>
  /// DdeValues.
  /// </summary>
  public DocumentModel.Office2010.Excel.IDdeValues? DdeValues { get ; set; }
  
}
