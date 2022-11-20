namespace DocumentModel.Presentation;

/// <summary>
/// Animate.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonBehavior))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ITimeAnimateValueList))]
public class Animate: IAnimate
{
  /// <summary>
  /// by
  /// </summary>
  public string? By
  {
    get;
    set;
  }
  
  /// <summary>
  /// from
  /// </summary>
  public string? From
  {
    get;
    set;
  }
  
  /// <summary>
  /// to
  /// </summary>
  public string? To
  {
    get;
    set;
  }
  
  /// <summary>
  /// calcmode
  /// </summary>
  public AnimateBehaviorCalculateModeValues? CalculationMode
  {
    get;
    set;
  }
  
  /// <summary>
  /// valueType
  /// </summary>
  public AnimateBehaviorValues? ValueType
  {
    get;
    set;
  }
  
  /// <summary>
  /// bounceEnd, this property is only available in Office 2010 and later.
  /// </summary>
  public int? BounceEnd
  {
    get;
    set;
  }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public ICommonBehavior? CommonBehavior
  {
    get;
    set;
  }
  
  /// <summary>
  /// TimeAnimateValueList.
  /// </summary>
  public ITimeAnimateValueList? TimeAnimateValueList
  {
    get;
    set;
  }
  
}
