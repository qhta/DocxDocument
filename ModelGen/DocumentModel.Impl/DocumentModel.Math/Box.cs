namespace DocumentModel.Math;

/// <summary>
/// Box Function.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IBoxProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IBase))]
public class Box: IBox
{
  /// <summary>
  /// Box Properties.
  /// </summary>
  public IBoxProperties? BoxProperties
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
