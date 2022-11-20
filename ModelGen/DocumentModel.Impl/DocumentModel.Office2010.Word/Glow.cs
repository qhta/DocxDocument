namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the Glow Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ISchemeColor))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IRgbColorModelHex))]
public class Glow: IGlow
{
  /// <summary>
  /// rad, this property is only available in Office 2010 and later.
  /// </summary>
  public long? GlowRadius
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
