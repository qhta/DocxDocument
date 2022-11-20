namespace DocumentModel.Math;

/// <summary>
/// Run Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IBreak))]
[ChildElementInfo(typeof(DocumentModel.Math.ILiteral))]
[ChildElementInfo(typeof(DocumentModel.Math.INormalText))]
[ChildElementInfo(typeof(DocumentModel.Math.IAlignment))]
[ChildElementInfo(typeof(DocumentModel.Math.IScript))]
[ChildElementInfo(typeof(DocumentModel.Math.IStyle))]
public class RunProperties: IRunProperties
{
  /// <summary>
  /// Literal.
  /// </summary>
  public DocumentModel.Math.ILiteral? Literal
  {
    get;
    set;
  }
  
}
