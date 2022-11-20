namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the TextBody Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBodyProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IListStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IParagraph))]
public class TextBody: ITextBody
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  public IBodyProperties? BodyProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public IListStyle? ListStyle
  {
    get;
    set;
  }
  
}
