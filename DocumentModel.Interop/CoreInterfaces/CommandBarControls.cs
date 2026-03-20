using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of command bar controls on a command bar.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrols?view=office-pia
/// </remarks>
public partial interface CommandBarControls: InteropDictionary<string, CommandBarControl>
{
}
