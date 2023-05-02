namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Latent Style Information.
/// </summary>
public partial class LatentStyles
{
  /// <summary>
  ///   Default Style Locking Setting
  /// </summary>
  //[DefaultValue(false)]
  public bool? DefaultLockedState { get; set; }

  /// <summary>
  ///   Default User Interface Priority Setting
  /// </summary>
  //[DefaultValue(0)]
  public Int32? DefaultUiPriority { get; set; }

  /// <summary>
  ///   Default Semi-Hidden Setting
  /// </summary>
  //[DefaultValue(false)]
  public bool? DefaultSemiHidden { get; set; }

  /// <summary>
  ///   Default Hidden Until Used Setting
  /// </summary>
  //[DefaultValue(false)]
  public bool? DefaultUnhideWhenUsed { get; set; }

  /// <summary>
  ///   Default Primary Style Setting
  /// </summary>
  //[DefaultValue(false)]
  public bool? DefaultPrimaryStyle { get; set; }

  /// <summary>
  ///   Latent Style Count
  /// </summary>
  //[DefaultValue(0)]
  public Int32? TotalCount { get; set; }

}