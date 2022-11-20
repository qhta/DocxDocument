namespace DocumentModel.Math;

/// <summary>
/// Bar.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IBarProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IBase))]
public class Bar: IBar
{
  /// <summary>
  /// Bar Properties.
  /// </summary>
  public IBarProperties? BarProperties
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
