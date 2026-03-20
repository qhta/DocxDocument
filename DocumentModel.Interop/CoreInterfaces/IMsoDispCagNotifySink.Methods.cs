
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodispcagnotifysink?view=office-pia
/// </remarks>
public partial interface IMsoDispCagNotifySink
{
  /// <summary>
  /// Inserts a clip.
  /// </summary>
  /// <param name="pClipMoniker">The `pClipMoniker` parameter.</param>
  /// <param name="pItemMoniker">The `pItemMoniker` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodispcagnotifysink.insertclip?view=office-pia
  /// </remarks>
  public void InsertClip(object pClipMoniker, object pItemMoniker);
  /// <summary>
  /// Indicates that the window is closing.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodispcagnotifysink.windowisclosing?view=office-pia
  /// </remarks>
  public void WindowIsClosing();
}
