namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.calloutformat?view=office-pia"/>
public partial class CalloutFormat
{


  #region methods

/// <summary>
  /// Resets callout length to automatic mode.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.calloutformat.automaticlength?view=office-pia"/>
  public void AutomaticLength() { throw new NotImplementedException(); }
  /// <summary>
  /// Sets a custom drop distance for the callout line.
  /// </summary>
  /// <param name="Drop">The `Drop` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.calloutformat.customdrop?view=office-pia"/>
  public void CustomDrop(float Drop) { throw new NotImplementedException(); }
  /// <summary>
  /// Sets a custom callout line length.
  /// </summary>
  /// <param name="Length">The `Length` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.calloutformat.customlength?view=office-pia"/>
  public void CustomLength(float Length) { throw new NotImplementedException(); }
  /// <summary>
  /// Applies a preset callout drop type.
  /// </summary>
  /// <param name="DropType">The `DropType` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.calloutformat.presetdrop?view=office-pia"/>
  public void PresetDrop(CalloutDropType DropType) { throw new NotImplementedException(); }

  #endregion methods
}

