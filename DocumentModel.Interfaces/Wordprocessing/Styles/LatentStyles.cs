namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents latent style information for a Wordprocessing document.
/// This interface provides properties for default style locking, UI priority, visibility, primary style settings, and style count, enabling advanced management and customization of latent styles.
/// </summary>
public partial interface LatentStyles
{
  
  /// <summary>
  /// Default style locking setting, indicating whether styles are locked by default.
  /// </summary>
  public bool? DefaultLockedState { get; set; }
  
  /// <summary>
  /// Default user interface priority setting, specifying the default sorting order for styles in the UI.
  /// </summary>
  public Int32? DefaultUiPriority { get; set; }
  
  /// <summary>
  /// Default semi-hidden setting, indicating whether styles are semi-hidden by default.
  /// </summary>
  public bool? DefaultSemiHidden { get; set; }
  
  /// <summary>
  /// Default hidden until used setting, indicating whether styles are hidden until used by default.
  /// </summary>
  public bool? DefaultUnhideWhenUsed { get; set; }
  
  /// <summary>
  /// Default primary style setting, indicating whether styles are primary by default.
  /// </summary>
  public bool? DefaultPrimaryStyle { get; set; }
  
  /// <summary>
  /// Latent style count, specifying the total number of latent styles defined in the document.
  /// </summary>
  public Int32? TotalCount { get; set; }
}