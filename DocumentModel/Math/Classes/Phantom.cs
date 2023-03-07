namespace DocumentModel.Math;

/// <summary>
///   Phantom Function.
/// </summary>
public class Phantom: DMW.IParagraphElement
{
  /// <summary>
  ///   Phantom Properties.
  /// </summary>
  public PhantomProperties? PhantomProperties { get; set; }

  /// <summary>
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }
}