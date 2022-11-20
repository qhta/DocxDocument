namespace DocumentModel.Drawing;

/// <summary>
/// Text Line Break.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IRunProperties))]
public class Break: IBreak
{
  /// <summary>
  /// Text Run Properties.
  /// </summary>
  public DocumentModel.Drawing.IRunProperties? RunProperties
  {
    get;
    set;
  }
  
}
