using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// A collection of command bar controls on a command bar.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrols?view=office-pia"/>
public partial interface CommandBarControls: IModelObject
{
  /// <summary>
  /// Adds a control to the command bar controls collection.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="Id">The `Id` parameter.</param>
  /// <param name="Parameter">The `Parameter` parameter.</param>
  /// <param name="Before">The `Before` parameter.</param>
  /// <param name="Temporary">The `Temporary` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrols.add?view=office-pia"/>
  public CommandBarControl Add(object Type, object Id, object Parameter, object Before, object Temporary);
}

