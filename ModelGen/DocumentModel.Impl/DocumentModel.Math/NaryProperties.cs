namespace DocumentModel.Math;

/// <summary>
/// n-ary Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IAccentChar))]
[ChildElementInfo(typeof(DocumentModel.Math.IControlProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.ILimitLocation))]
[ChildElementInfo(typeof(DocumentModel.Math.IGrowOperators))]
[ChildElementInfo(typeof(DocumentModel.Math.IHideSubArgument))]
[ChildElementInfo(typeof(DocumentModel.Math.IHideSuperArgument))]
public class NaryProperties: INaryProperties
{
  /// <summary>
  /// n-ary Operator Character.
  /// </summary>
  public IAccentChar? AccentChar
  {
    get;
    set;
  }
  
  /// <summary>
  /// n-ary Limit Location.
  /// </summary>
  public ILimitLocation? LimitLocation
  {
    get;
    set;
  }
  
  /// <summary>
  /// n-ary Grow.
  /// </summary>
  public IGrowOperators? GrowOperators
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hide Subscript (n-ary).
  /// </summary>
  public IHideSubArgument? HideSubArgument
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hide Superscript (n-ary).
  /// </summary>
  public IHideSuperArgument? HideSuperArgument
  {
    get;
    set;
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.IControlProperties? ControlProperties
  {
    get;
    set;
  }
  
}
