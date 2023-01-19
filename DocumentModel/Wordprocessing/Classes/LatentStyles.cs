namespace DocumentModel.Wordprocessing;

/// <summary>
///   Latent Style Information.
/// </summary>
public partial class LatentStyles
{
  /// <summary>
  ///   Default Style Locking Setting
  /// </summary>
  public Boolean? DefaultLockedState { get; set; }

  /// <summary>
  ///   Default User Interface Priority Setting
  /// </summary>
  public Int32? DefaultUiPriority { get; set; }

  /// <summary>
  ///   Default Semi-Hidden Setting
  /// </summary>
  public Boolean? DefaultSemiHidden { get; set; }

  /// <summary>
  ///   Default Hidden Until Used Setting
  /// </summary>
  public Boolean? DefaultUnhideWhenUsed { get; set; }

  /// <summary>
  ///   Default Primary Style Setting
  /// </summary>
  public Boolean? DefaultPrimaryStyle { get; set; }

  /// <summary>
  ///   Latent Style Count
  /// </summary>
  public Int32? TotalCount { get; set; }

  //public Collection<LatentStyleExceptionInfo>? Items { get; set; }
}