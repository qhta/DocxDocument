namespace DocumentModel.Presentation;

/// <summary>
/// Background Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlipFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectDag))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGradientFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INoFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPatternFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISolidFill))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public class BackgroundProperties: IBackgroundProperties
{
  /// <summary>
  /// Shade to Title
  /// </summary>
  public bool? ShadeToTitle
  {
    get;
    set;
  }
  
}
