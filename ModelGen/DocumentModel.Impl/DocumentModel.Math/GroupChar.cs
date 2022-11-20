namespace DocumentModel.Math;

/// <summary>
/// Group-Character Function.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IGroupCharProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IBase))]
public class GroupChar: IGroupChar
{
  /// <summary>
  /// Group-Character Properties.
  /// </summary>
  public IGroupCharProperties? GroupCharProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public IBase? Base
  {
    get;
    set;
  }
  
}
