namespace DocumentModel.Math;

/// <summary>
/// Phantom Function.
/// </summary>
public interface IPhantom // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Phantom Properties.
  /// </summary>
  public DocumentModel.Math.IPhantomProperties? PhantomProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.IBase? Base { get ; set; }
  
}
