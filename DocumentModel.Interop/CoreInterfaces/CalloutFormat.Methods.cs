
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.calloutformat?view=office-pia
/// </remarks>
public partial interface CalloutFormat
{
  /// <summary>
  /// Resets callout length to automatic mode.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.calloutformat.automaticlength?view=office-pia
  /// </remarks>
  public void AutomaticLength();
  /// <summary>
  /// Sets a custom drop distance for the callout line.
  /// </summary>
  /// <param name="Drop">The `Drop` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.calloutformat.customdrop?view=office-pia
  /// </remarks>
  public void CustomDrop(float Drop);
  /// <summary>
  /// Sets a custom callout line length.
  /// </summary>
  /// <param name="Length">The `Length` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.calloutformat.customlength?view=office-pia
  /// </remarks>
  public void CustomLength(float Length);
  /// <summary>
  /// Applies a preset callout drop type.
  /// </summary>
  /// <param name="DropType">The `DropType` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.calloutformat.presetdrop?view=office-pia
  /// </remarks>
  public void PresetDrop(MsoCalloutDropType DropType);
}
