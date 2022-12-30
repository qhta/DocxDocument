namespace DocumentModel.Wordprocessing;

/// <summary>
/// Latent Style Exception.
/// </summary>
public partial class LatentStyleExceptionInfo
{
  /// <summary>
  /// Primary Style Name
  /// </summary>
  public String? Name { get; set; }
  
  /// <summary>
  /// Latent Style Locking Setting
  /// </summary>
  public Boolean? Locked { get; set; }
  
  /// <summary>
  /// Override default sorting order
  /// </summary>
  public Int32? UiPriority { get; set; }
  
  /// <summary>
  /// Semi hidden text override
  /// </summary>
  public Boolean? SemiHidden { get; set; }
  
  /// <summary>
  /// Unhide when used
  /// </summary>
  public Boolean? UnhideWhenUsed { get; set; }
  
  /// <summary>
  /// Latent Style Primary Style Setting
  /// </summary>
  public Boolean? PrimaryStyle { get; set; }
  
}
