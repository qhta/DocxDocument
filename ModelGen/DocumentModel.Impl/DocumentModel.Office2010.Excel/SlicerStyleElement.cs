namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SlicerStyleElement Class.
/// </summary>
public class SlicerStyleElement: ISlicerStyleElement
{
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public SlicerStyleTypeValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// dxfId, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? FormatId
  {
    get;
    set;
  }
  
}
