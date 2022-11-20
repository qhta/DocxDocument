namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtPlaceholder Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocPartReference))]
public class SdtPlaceholder: ISdtPlaceholder
{
  /// <summary>
  /// Document Part Reference.
  /// </summary>
  public IDocPartReference? DocPartReference
  {
    get;
    set;
  }
  
}
