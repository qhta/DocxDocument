namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the ExtensionListModify Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtension))]
public class ExtensionListModify: IExtensionListModify
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
