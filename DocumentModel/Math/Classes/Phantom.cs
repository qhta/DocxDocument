namespace DocumentModel.Math;

/// <summary>
///   Phantom Function.
/// </summary>
public record Phantom: DMW.ParagraphElement
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