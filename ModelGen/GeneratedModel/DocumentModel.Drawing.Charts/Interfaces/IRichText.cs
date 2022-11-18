namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Rich Text.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBodyProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IListStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IParagraph))]
public interface IRichText // : DocumentFormat.OpenXml.Drawing.Charts.TextBodyType
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  public IBodyProperties? BodyProperties { get ; set; }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public IListStyle? ListStyle { get ; set; }
  
}
