namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the SchemeColor Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ISaturation))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ISaturationOffset))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ISaturationModulation))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ILuminance))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ILuminanceOffset))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ILuminanceModulation))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ITint))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IShade))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IAlpha))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IHueModulation))]
public class SchemeColor: ISchemeColor
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.SchemeColorValues? Val
  {
    get;
    set;
  }
  
}
