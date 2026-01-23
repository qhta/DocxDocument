using System.ComponentModel;
namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents extended latent style exception information for a Wordprocessing document.
/// This class provides properties for the primary style name and alternate style names, enabling advanced management and customization of latent styles. Implements property change notification interfaces.
/// </summary>
public partial class LatentStyleExceptionInfo
{
  
  /// <summary>
  /// Primary style name associated with the latent style exception.
  /// </summary>
  public string? StyleName { get; set; }
  
  /// <summary>
  /// Alternate style names associated with the latent style exception.
  /// </summary>
  public ListOf<String>? Aliases { get; set; }
}