namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the TextBodyType Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBodyProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IListStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IParagraph))]
public class TextBodyType: ITextBodyType
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
