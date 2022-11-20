namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Whole E2O Formatting.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectDag))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IOutline))]
public class Whole: IWhole
{
  /// <summary>
  /// Outline.
  /// </summary>
  public DocumentModel.Drawing.IOutline? Outline
  {
    get;
    set;
  }
  
}
