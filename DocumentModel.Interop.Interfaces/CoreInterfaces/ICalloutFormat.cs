namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.calloutformat?view=office-pia"/>
public interface ICalloutFormat
{


  #region methods

/// <summary>
  /// Resets callout length to automatic mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.calloutformat.automaticlength?view=office-pia"/>
  public void AutomaticLength();
  /// <summary>
  /// Sets a custom drop distance for the callout line.
  /// </summary>
  /// <param name="drop">The `Drop` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.calloutformat.customdrop?view=office-pia"/>
  public void CustomDrop(float drop);
  /// <summary>
  /// Sets a custom callout line length.
  /// </summary>
  /// <param name="length">The `Length` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.calloutformat.customlength?view=office-pia"/>
  public void CustomLength(float length);
  /// <summary>
  /// Applies a preset callout drop type.
  /// </summary>
  /// <param name="dropType">The `DropType` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.calloutformat.presetdrop?view=office-pia"/>
  public void PresetDrop(CalloutDropType dropType);

  #endregion methods
}

