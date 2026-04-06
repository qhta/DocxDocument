using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// A collection of command bar controls on a command bar.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrols?view=office-pia"/>
public partial interface ICommandBarControls: IModelCollection<ICommandBarControl>
{
}

