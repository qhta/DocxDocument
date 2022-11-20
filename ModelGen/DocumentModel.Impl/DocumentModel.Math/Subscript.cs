namespace DocumentModel.Math;

/// <summary>
/// Subscript Function.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IBase))]
[ChildElementInfo(typeof(DocumentModel.Math.ISubArgument))]
[ChildElementInfo(typeof(DocumentModel.Math.ISubscriptProperties))]
public class Subscript: ISubscript
{
  /// <summary>
  /// Subscript Properties.
  /// </summary>
  public ISubscriptProperties? SubscriptProperties
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
  
  /// <summary>
  /// Subscript (Subscript function).
  /// </summary>
  public ISubArgument? SubArgument
  {
    get;
    set;
  }
  
}
