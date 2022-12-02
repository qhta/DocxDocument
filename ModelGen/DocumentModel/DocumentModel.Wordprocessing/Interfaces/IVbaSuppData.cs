namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VbaSuppData Class.
/// </summary>
public interface IVbaSuppData // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// DocEvents.
  /// </summary>
  public IDocEvents? DocEvents { get ; set; }
  
  /// <summary>
  /// Mcds.
  /// </summary>
  public IMcds? Mcds { get ; set; }
  
}
