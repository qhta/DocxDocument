namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the GradientFillProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IGradientStopList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ILinearShadeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IPathShadeProperties))]
public class GradientFillProperties: IGradientFillProperties
{
  /// <summary>
  /// GradientStopList.
  /// </summary>
  public DocumentModel.Office2010.Word.IGradientStopList? GradientStopList
  {
    get;
    set;
  }
  
}
