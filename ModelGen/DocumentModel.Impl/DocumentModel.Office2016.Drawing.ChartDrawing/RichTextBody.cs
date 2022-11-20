namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the RichTextBody Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBodyProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IListStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IParagraph))]
public class RichTextBody: IRichTextBody
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
