
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoDispCagNotifySink` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodispcagnotifysink?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoDispCagNotifySink
{
  /// <summary>
  /// Invokes `InsertClip`.
  /// </summary>
  /// <param name="pClipMoniker">The `pClipMoniker` parameter.</param>
  /// <param name="pItemMoniker">The `pItemMoniker` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodispcagnotifysink.insertclip?view=office-pia
  /// </remarks>
  public void InsertClip(object pClipMoniker, object pItemMoniker);
  /// <summary>
  /// Invokes `WindowIsClosing`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodispcagnotifysink.windowisclosing?view=office-pia
  /// </remarks>
  public void WindowIsClosing();
}
