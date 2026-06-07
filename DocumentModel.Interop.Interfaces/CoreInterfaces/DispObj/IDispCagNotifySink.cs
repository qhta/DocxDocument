
namespace DocumentModel.Interop.Core;
/// <summary>
/// Disp cag notify sink isn't a single feature, but rather a combination of technical terms related to Windows
/// software development and Microsoft Office processes. It describes how different parts of your system "talk" to each other.
/// </summary>
/// <remarks>
/// Here is the breakdown of what those terms mean:
/// <list type="bullet">
/// <item>
/// <term>Disp</term>
/// <description>Short for Dispatch (or a dispatch interface/dispatch ID). In Windows programming, this is typically used to expose object methods and properties to other applications.</description>
/// </item>
/// <item>
/// <term>Cag</term>
/// <description>An acronym that stands for Common Alert Group or a specific software component/data collection process. In the context of Microsoft Word, it often references a background telemetry or communication process, especially when sending logs to crash or diagnostics servers.</description>
/// </item>
/// <item>
/// <term>Notify</term>
/// <description>A programming command that tells an application an event has occurred or a property has changed.</description>
/// </item>
/// <item>
/// <term>Sink</term>
/// <description>In software, a Sink is the destination end of a communication channel or event handler. An object "notifies" a "sink" that something has happened so the sink can process the information.</description>
/// </item>
/// </list>
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodispcagnotifysink?view=office-pia"/>
public interface IDispCagNotifySink
{	

  #region methods	
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
  #endregion methods
}	

