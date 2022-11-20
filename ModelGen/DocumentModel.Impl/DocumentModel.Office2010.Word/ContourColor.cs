namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the ContourColor Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ISchemeColor))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IRgbColorModelHex))]
public class ContourColor: IContourColor
{
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
