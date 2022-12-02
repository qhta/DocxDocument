namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VbaSuppData Class.
/// </summary>
public interface IVbaSuppData // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// DocEvents.
  /// </summary>
  public DocumentModel.Wordprocessing.IDocEvents? DocEvents { get ; set; }
  
  /// <summary>
  /// Mcds.
  /// </summary>
  public DocumentModel.Wordprocessing.IMcds? Mcds { get ; set; }
  
}
