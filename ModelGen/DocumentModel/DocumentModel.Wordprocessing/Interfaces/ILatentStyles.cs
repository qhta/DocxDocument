namespace DocumentModel.Wordprocessing;

/// <summary>
/// Latent Style Information.
/// </summary>
public interface ILatentStyles // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Default Style Locking Setting
  /// </summary>
  public System.Boolean? DefaultLockedState { get ; set; }
  
  /// <summary>
  /// Default User Interface Priority Setting
  /// </summary>
  public System.Int32? DefaultUiPriority { get ; set; }
  
  /// <summary>
  /// Default Semi-Hidden Setting
  /// </summary>
  public System.Boolean? DefaultSemiHidden { get ; set; }
  
  /// <summary>
  /// Default Hidden Until Used Setting
  /// </summary>
  public System.Boolean? DefaultUnhideWhenUsed { get ; set; }
  
  /// <summary>
  /// Default Primary Style Setting
  /// </summary>
  public System.Boolean? DefaultPrimaryStyle { get ; set; }
  
  /// <summary>
  /// Latent Style Count
  /// </summary>
  public System.Int32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ILatentStyleExceptionInfo>? LatentStyleExceptionInfos { get ; set; }
  
}
