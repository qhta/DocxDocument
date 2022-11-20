namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the WorkbookProperties Class.
/// </summary>
public class WorkbookProperties: IWorkbookProperties
{
  /// <summary>
  /// defaultImageDpi, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? DefaultImageDpi
  {
    get;
    set;
  }
  
  /// <summary>
  /// discardImageEditData, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? DiscardImageEditData
  {
    get;
    set;
  }
  
  /// <summary>
  /// accuracyVersion, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? AccuracyVersion
  {
    get;
    set;
  }
  
}
