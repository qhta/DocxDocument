namespace DocumentModel.Wordprocessing;

/// <summary>
/// Latent Style Information.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILatentStyleExceptionInfo))]
public interface ILatentStyles // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Default Style Locking Setting
  /// </summary>
  public bool? DefaultLockedState { get ; set; }
  
  /// <summary>
  /// Default User Interface Priority Setting
  /// </summary>
  public int? DefaultUiPriority { get ; set; }
  
  /// <summary>
  /// Default Semi-Hidden Setting
  /// </summary>
  public bool? DefaultSemiHidden { get ; set; }
  
  /// <summary>
  /// Default Hidden Until Used Setting
  /// </summary>
  public bool? DefaultUnhideWhenUsed { get ; set; }
  
  /// <summary>
  /// Default Primary Style Setting
  /// </summary>
  public bool? DefaultPrimaryStyle { get ; set; }
  
  /// <summary>
  /// Latent Style Count
  /// </summary>
  public int? Count { get ; set; }
  
}
