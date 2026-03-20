using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of CommandBar objects that represent the command bars in the container application.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars?view=office-pia
/// </remarks>
public partial interface _CommandBars
{
  /// <summary>
  /// Creates a new command bar and adds it to the command bars collection.
  /// </summary>
  /// <param name="Name">The `Name` parameter.</param>
  /// <param name="Position">The `Position` parameter.</param>
  /// <param name="MenuBar">The `MenuBar` parameter.</param>
  /// <param name="Temporary">The `Temporary` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.add?view=office-pia
  /// </remarks>
  public CommandBar Add(object Name, object Position, object MenuBar, object Temporary);
  /// <summary>
  /// Finds a single command bar control that matches the specified criteria.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="Id">The `Id` parameter.</param>
  /// <param name="Tag">The `Tag` parameter.</param>
  /// <param name="Visible">The `Visible` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.findcontrol?view=office-pia
  /// </remarks>
  public CommandBarControl FindControl(object Type, object Id, object Tag, object Visible);
  /// <summary>
  /// Releases focus from the command bars user interface.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.releasefocus?view=office-pia
  /// </remarks>
  public void ReleaseFocus();
  /// <summary>
  /// Finds all command bar controls that match the specified criteria.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="Id">The `Id` parameter.</param>
  /// <param name="Tag">The `Tag` parameter.</param>
  /// <param name="Visible">The `Visible` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.findcontrols?view=office-pia
  /// </remarks>
  public CommandBarControls FindControls(object Type, object Id, object Tag, object Visible);
  /// <summary>
  /// Invokes `AddEx`.
  /// </summary>
  /// <param name="TbidOrName">The `TbidOrName` parameter.</param>
  /// <param name="Position">The `Position` parameter.</param>
  /// <param name="MenuBar">The `MenuBar` parameter.</param>
  /// <param name="Temporary">The `Temporary` parameter.</param>
  /// <param name="TbtrProtection">The `TbtrProtection` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.addex?view=office-pia
  /// </remarks>
  public CommandBar AddEx(object TbidOrName, object Position, object MenuBar, object Temporary, object TbtrProtection);
  /// <summary>
  /// Executes the built-in control identified by the specified `idMso` value.
  /// </summary>
  /// <param name="idMso">The `idMso` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.executemso?view=office-pia
  /// </remarks>
  public void ExecuteMso(string idMso);
  /// <summary>
  /// Invokes `GetEnabledMso`.
  /// </summary>
  /// <param name="idMso">The `idMso` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.getenabledmso?view=office-pia
  /// </remarks>
  public bool GetEnabledMso(string idMso);
  /// <summary>
  /// Invokes `GetVisibleMso`.
  /// </summary>
  /// <param name="idMso">The `idMso` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.getvisiblemso?view=office-pia
  /// </remarks>
  public bool GetVisibleMso(string idMso);
  /// <summary>
  /// Invokes `GetPressedMso`.
  /// </summary>
  /// <param name="idMso">The `idMso` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.getpressedmso?view=office-pia
  /// </remarks>
  public bool GetPressedMso(string idMso);
  /// <summary>
  /// Invokes `GetLabelMso`.
  /// </summary>
  /// <param name="idMso">The `idMso` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.getlabelmso?view=office-pia
  /// </remarks>
  public string GetLabelMso(string idMso);
  /// <summary>
  /// Invokes `GetScreentipMso`.
  /// </summary>
  /// <param name="idMso">The `idMso` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.getscreentipmso?view=office-pia
  /// </remarks>
  public string GetScreentipMso(string idMso);
  /// <summary>
  /// Invokes `GetSupertipMso`.
  /// </summary>
  /// <param name="idMso">The `idMso` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.getsupertipmso?view=office-pia
  /// </remarks>
  public string GetSupertipMso(string idMso);
  /// <summary>
  /// Invokes `GetImageMso`.
  /// </summary>
  /// <param name="idMso">The `idMso` parameter.</param>
  /// <param name="Width">The `Width` parameter.</param>
  /// <param name="Height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.getimagemso?view=office-pia
  /// </remarks>
  public object GetImageMso(string idMso, int Width, int Height);
  /// <summary>
  /// Invokes `CommitRenderingTransaction`.
  /// </summary>
  /// <param name="hwnd">The `hwnd` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.commitrenderingtransaction?view=office-pia
  /// </remarks>
  public void CommitRenderingTransaction(int hwnd);
}
