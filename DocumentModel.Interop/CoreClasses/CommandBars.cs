using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of CommandBar objects that represent the command bars in the container application.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars?view=office-pia"/>
public partial class CommandBars: InteropCollection<CommandBar>
{
  /// <summary>
  /// Gets or sets the `ActionControl` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.actioncontrol?view=office-pia"/>
  public CommandBarControl ActionControl { get; }
  /// <summary>
  /// Gets the `ActiveMenuBar` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.activemenubar?view=office-pia"/>
  public CommandBar ActiveMenuBar { get; }
  /// <summary>
  /// Gets or sets the `DisplayTooltips` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.displaytooltips?view=office-pia"/>
  public bool DisplayTooltips { get; set; }
  /// <summary>
  /// Gets or sets the `DisplayKeysInTooltips` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.displaykeysintooltips?view=office-pia"/>
  public bool DisplayKeysInTooltips { get; set; }
  /// <summary>
  /// Gets or sets the `LargeButtons` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.largebuttons?view=office-pia"/>
  public bool LargeButtons { get; set; }
  /// <summary>
  /// Gets or sets the `MenuAnimationStyle` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.menuanimationstyle?view=office-pia"/>
  public MenuAnimation MenuAnimationStyle { get; set; }
  /// <summary>
  /// Gets the `IdsString` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.idsstring?view=office-pia"/>
  public int IdsString { get; }
  /// <summary>
  /// Gets the `TmcGetName` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.tmcgetname?view=office-pia"/>
  public int TmcGetName { get; }
  /// <summary>
  /// Gets or sets the `AdaptiveMenus` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.adaptivemenus?view=office-pia"/>
  public bool AdaptiveMenus { get; set; }
  /// <summary>
  /// Gets or sets the `DisplayFonts` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.displayfonts?view=office-pia"/>
  public bool DisplayFonts { get; set; }
  /// <summary>
  /// Gets or sets the `DisableCustomize` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.disablecustomize?view=office-pia"/>
  public bool DisableCustomize { get; set; }
  /// <summary>
  /// Gets or sets the `DisableAskAQuestionDropdown` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.disableaskaquestiondropdown?view=office-pia"/>
  public bool DisableAskAQuestionDropdown { get; set; }


  #region methods

/// <summary>
  /// Creates a new command bar and adds it to the command bars collection.
  /// </summary>
  /// <param name="name">The `Name` parameter.</param>
  /// <param name="position">The `Position` parameter.</param>
  /// <param name="menuBar">The `MenuBar` parameter.</param>
  /// <param name="temporary">The `Temporary` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.add?view=office-pia"/>
  public CommandBar Add(object name, object position, object menuBar, object temporary) { throw new NotImplementedException(); }
  /// <summary>
  /// Finds a single command bar control that matches the specified criteria.
  /// </summary>
  /// <param name="type">The `Type` parameter.</param>
  /// <param name="id">The `Id` parameter.</param>
  /// <param name="tag">The `Tag` parameter.</param>
  /// <param name="visible">The `Visible` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.findcontrol?view=office-pia"/>
  public CommandBarControl FindControl(object type, object id, object tag, object visible) { throw new NotImplementedException(); }
  /// <summary>
  /// Releases focus from the command bars user class.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.releasefocus?view=office-pia"/>
  public void ReleaseFocus() { throw new NotImplementedException(); }
  /// <summary>
  /// Finds all command bar controls that match the specified criteria.
  /// </summary>
  /// <param name="type">The `Type` parameter.</param>
  /// <param name="id">The `Id` parameter.</param>
  /// <param name="tag">The `Tag` parameter.</param>
  /// <param name="visible">The `Visible` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.findcontrols?view=office-pia"/>
  public CommandBarControls FindControls(object type, object id, object tag, object visible) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddEx`.
  /// </summary>
  /// <param name="tbidOrName">The `TbidOrName` parameter.</param>
  /// <param name="position">The `Position` parameter.</param>
  /// <param name="menuBar">The `MenuBar` parameter.</param>
  /// <param name="temporary">The `Temporary` parameter.</param>
  /// <param name="tbtrProtection">The `TbtrProtection` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.addex?view=office-pia"/>
  public CommandBar AddEx(object tbidOrName, object position, object menuBar, object temporary, object tbtrProtection) { throw new NotImplementedException(); }
  /// <summary>
  /// Executes the built-in control identified by the specified `idMso` value.
  /// </summary>
  /// <param name="idMso">The `idMso` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.executemso?view=office-pia"/>
  public void ExecuteMso(string idMso) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetEnabledMso`.
  /// </summary>
  /// <param name="idMso">The `idMso` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.getenabledmso?view=office-pia"/>
  public bool GetEnabledMso(string idMso) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetVisibleMso`.
  /// </summary>
  /// <param name="idMso">The `idMso` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.getvisiblemso?view=office-pia"/>
  public bool GetVisibleMso(string idMso) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetPressedMso`.
  /// </summary>
  /// <param name="idMso">The `idMso` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.getpressedmso?view=office-pia"/>
  public bool GetPressedMso(string idMso) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetLabelMso`.
  /// </summary>
  /// <param name="idMso">The `idMso` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.getlabelmso?view=office-pia"/>
  public string GetLabelMso(string idMso) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetScreentipMso`.
  /// </summary>
  /// <param name="idMso">The `idMso` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.getscreentipmso?view=office-pia"/>
  public string GetScreentipMso(string idMso) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetSupertipMso`.
  /// </summary>
  /// <param name="idMso">The `idMso` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.getsupertipmso?view=office-pia"/>
  public string GetSupertipMso(string idMso) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetImageMso`.
  /// </summary>
  /// <param name="idMso">The `idMso` parameter.</param>
  /// <param name="width">The `Width` parameter.</param>
  /// <param name="height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.getimagemso?view=office-pia"/>
  public object GetImageMso(string idMso, int width, int height) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `CommitRenderingTransaction`.
  /// </summary>
  /// <param name="hwnd">The `hwnd` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.commitrenderingtransaction?view=office-pia"/>
  public void CommitRenderingTransaction(int hwnd) { throw new NotImplementedException(); }

  #endregion methods
}

