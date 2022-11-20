namespace DocumentModel.Wordprocessing;

/// <summary>
/// Latent Style Exception.
/// </summary>
public class LatentStyleExceptionInfo: ILatentStyleExceptionInfo
{
  /// <summary>
  /// Primary Style Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Latent Style Locking Setting
  /// </summary>
  public bool? Locked
  {
    get;
    set;
  }
  
  /// <summary>
  /// Override default sorting order
  /// </summary>
  public int? UiPriority
  {
    get;
    set;
  }
  
  /// <summary>
  /// Semi hidden text override
  /// </summary>
  public bool? SemiHidden
  {
    get;
    set;
  }
  
  /// <summary>
  /// Unhide when used
  /// </summary>
  public bool? UnhideWhenUsed
  {
    get;
    set;
  }
  
  /// <summary>
  /// Latent Style Primary Style Setting
  /// </summary>
  public bool? PrimaryStyle
  {
    get;
    set;
  }
  
}
