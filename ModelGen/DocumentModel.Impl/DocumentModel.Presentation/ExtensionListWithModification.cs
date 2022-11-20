namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ExtensionListWithModification Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtension))]
public class ExtensionListWithModification: IExtensionListWithModification
{
  /// <summary>
  /// Modify
  /// </summary>
  public bool? Modify
  {
    get;
    set;
  }
  
}
