namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the RichStyle Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.RichData2.IRichStylePropertyValue))]
public class RichStyle: IRichStyle
{
  /// <summary>
  /// dxfid, this property is only available in Office 2019 and later.
  /// </summary>
  public uint? Dxfid
  {
    get;
    set;
  }
  
}
