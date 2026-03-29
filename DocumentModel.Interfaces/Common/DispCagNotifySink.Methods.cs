
namespace DocumentModel.Application;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodispcagnotifysink?view=office-pia"/>
public partial interface DispCagNotifySink: InteropObject
{
  /// <summary>
  /// Inserts a clip.
  /// </summary>
  /// <param name="pClipMoniker">The `pClipMoniker` parameter.</param>
  /// <param name="pItemMoniker">The `pItemMoniker` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodispcagnotifysink.insertclip?view=office-pia"/>
  public void InsertClip(object pClipMoniker, object pItemMoniker);
  /// <summary>
  /// Indicates that the window is closing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodispcagnotifysink.windowisclosing?view=office-pia"/>
  public void WindowIsClosing();
}

