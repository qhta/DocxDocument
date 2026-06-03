using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of command bar controls on a command bar.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrols?view=office-pia"/>
public interface ICommandBarControls: IInteropCollection<ICommandBarControl>
{


  #region methods

/// <summary>
  /// Adds a control to the command bar controls collection.
  /// </summary>
  /// <param name="type">The `Type` parameter.</param>
  /// <param name="id">The `Id` parameter.</param>
  /// <param name="parameter">The `Parameter` parameter.</param>
  /// <param name="before">The `Before` parameter.</param>
  /// <param name="temporary">The `Temporary` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrols.add?view=office-pia"/>
  public ICommandBarControl Add(object type, object id, object parameter, object before, object temporary);

  #endregion methods
}

