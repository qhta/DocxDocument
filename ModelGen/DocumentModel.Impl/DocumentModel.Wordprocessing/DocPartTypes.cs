namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Types.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocPartType))]
public class DocPartTypes: IDocPartTypes
{
  /// <summary>
  /// Entry Is Of All Types
  /// </summary>
  public bool? All
  {
    get;
    set;
  }
  
}
