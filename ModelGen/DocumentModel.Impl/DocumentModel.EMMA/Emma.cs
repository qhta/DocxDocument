namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Emma Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.EMMA.IDerivation))]
[ChildElementInfo(typeof(DocumentModel.EMMA.IEndPointInfo))]
[ChildElementInfo(typeof(DocumentModel.EMMA.IGrammar))]
[ChildElementInfo(typeof(DocumentModel.EMMA.IGroup))]
[ChildElementInfo(typeof(DocumentModel.EMMA.IInfo))]
[ChildElementInfo(typeof(DocumentModel.EMMA.IInterpretation))]
[ChildElementInfo(typeof(DocumentModel.EMMA.IModel))]
[ChildElementInfo(typeof(DocumentModel.EMMA.IOneOf))]
[ChildElementInfo(typeof(DocumentModel.EMMA.ISequence))]
public class Emma: IEmma
{
  /// <summary>
  /// version
  /// </summary>
  public string? Version
  {
    get;
    set;
  }
  
}
