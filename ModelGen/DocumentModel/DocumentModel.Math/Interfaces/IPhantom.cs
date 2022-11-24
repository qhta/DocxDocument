namespace DocumentModel.Math;

/// <summary>
/// Phantom Function.
/// </summary>
public interface IPhantom // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Phantom Properties.
  /// </summary>
  public IPhantomProperties? PhantomProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public IBase? Base { get ; set; }
  
}
