namespace DocumentModel.Math;

/// <summary>
/// Phantom Function.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IBase))]
[ChildElementInfo(typeof(DocumentModel.Math.IPhantomProperties))]
public class Phantom: IPhantom
{
  /// <summary>
  /// Phantom Properties.
  /// </summary>
  public IPhantomProperties? PhantomProperties
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
