namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the GradientStop Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ISchemeColor))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IRgbColorModelHex))]
public class GradientStop: IGradientStop
{
  /// <summary>
  /// pos, this property is only available in Office 2010 and later.
  /// </summary>
  public int? StopPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public DocumentModel.Office2010.Word.IRgbColorModelHex? RgbColorModelHex
  {
    get;
    set;
  }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public DocumentModel.Office2010.Word.ISchemeColor? SchemeColor
  {
    get;
    set;
  }
  
}
