namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents latent style exception information for a Wordprocessing document.
/// This class provides properties for style name, locking, UI priority, visibility, and primary style settings, enabling advanced management and customization of latent styles.
/// </summary>
public partial class LatentStyleExceptionInfo : ModelElement<DXW.LatentStyleExceptionInfo>
{
  /// <summary>
  /// Primary style name associated with the latent style exception.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  /// Indicates whether the latent style is locked and cannot be modified.
  /// </summary>
  public bool? Locked { get; set; }

  /// <summary>
  /// Override for the default sorting order in the UI, specifying the priority of the style.
  /// </summary>
  public Int32? UiPriority { get; set; }

  /// <summary>
  /// Indicates whether the style is semi-hidden, overriding default visibility settings.
  /// </summary>
  public bool? SemiHidden { get; set; }

  /// <summary>
  /// Indicates whether the style should be unhidden when used in the document.
  /// </summary>
  public bool? UnhideWhenUsed { get; set; }

  /// <summary>
  /// Indicates whether the style is a primary style in the latent style set.
  /// </summary>
  public bool? PrimaryStyle { get; set; }
}