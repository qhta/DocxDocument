namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Paragraph Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IParagraphPropertiesBaseStyle))]
public class ParagraphPropertiesDefault: IParagraphPropertiesDefault
{
  /// <summary>
  /// Paragraph Properties.
  /// </summary>
  public IParagraphPropertiesBaseStyle? ParagraphPropertiesBaseStyle
  {
    get;
    set;
  }
  
}
