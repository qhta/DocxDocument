namespace DocumentModel.Presentation;

/// <summary>
/// Template Effects.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ITimeNodeList))]
public class Template: ITemplate
{
  /// <summary>
  /// Level
  /// </summary>
  public uint? Level
  {
    get;
    set;
  }
  
  /// <summary>
  /// Time Node List.
  /// </summary>
  public ITimeNodeList? TimeNodeList
  {
    get;
    set;
  }
  
}
