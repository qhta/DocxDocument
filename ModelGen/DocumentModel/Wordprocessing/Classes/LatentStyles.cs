namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the properties which shall be applied to a set of latent styles for this document. Latent styles refer to any set of style definitions known to an application which have not been included in the current document.
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
  public Int32? Count { get; set; }
  
  public ElementCollection<LatentStyleExceptionInfo>? Items { get; set; }
  
}
