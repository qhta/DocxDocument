namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Default Paragraph and Run Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IParagraphPropertiesDefault))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRunPropertiesDefault))]
public class DocDefaults: IDocDefaults
{
  /// <summary>
  /// Default Run Properties.
  /// </summary>
  public IRunPropertiesDefault? RunPropertiesDefault
  {
    get;
    set;
  }
  
  /// <summary>
  /// Default Paragraph Properties.
  /// </summary>
  public IParagraphPropertiesDefault? ParagraphPropertiesDefault
  {
    get;
    set;
  }
  
}
