namespace DocumentModel.Math;

/// <summary>
/// Phantom Function.
/// </summary>
public class PhantomImpl: ModelElement<DocumentFormat.OpenXml.Math.Phantom>, Phantom
{
  /// <summary>
  /// Phantom Properties.
  /// </summary>
  public PhantomProperties? PhantomProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public Base? Base
  {
    get;
    set;
  }
  
}
