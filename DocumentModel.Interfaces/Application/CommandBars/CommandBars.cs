
namespace DocumentModel.Application;

/// <summary>
/// A collection of command bars in the container application.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbars?view=office-pia"/>
public partial interface ICommandBars
{

  /// <summary>
  /// Gets or sets the `ActionControl` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.actioncontrol?view=office-pia"/>
  public ICommandBarControl ActionControl { get; }
  /// <summary>
  /// Gets the `ActiveMenuBar` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.activemenubar?view=office-pia"/>
  public ICommandBar ActiveMenuBar { get; }
  /// <summary>
  /// Gets or sets the `DisplayTooltips` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.displaytooltips?view=office-pia"/>
  public bool DisplayTooltips { get; set; }
  /// <summary>
  /// Gets or sets the `DisplayKeysInTooltips` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.displaykeysintooltips?view=office-pia"/>
  public bool DisplayKeysInTooltips { get; set; }
  /// <summary>
  /// Gets or sets the `LargeButtons` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.largebuttons?view=office-pia"/>
  public bool LargeButtons { get; set; }
  /// <summary>
  /// Gets or sets the `MenuAnimationStyle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.menuanimationstyle?view=office-pia"/>
  public MenuAnimation MenuAnimationStyle { get; set; }
  /// <summary>
  /// Gets the `IdsString` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.idsstring?view=office-pia"/>
  public int IdsString { get; }
  /// <summary>
  /// Gets the `TmcGetName` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.tmcgetname?view=office-pia"/>
  public int TmcGetName { get; }
  /// <summary>
  /// Gets or sets the `AdaptiveMenus` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.adaptivemenus?view=office-pia"/>
  public bool AdaptiveMenus { get; set; }
  /// <summary>
  /// Gets or sets the `DisplayFonts` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.displayfonts?view=office-pia"/>
  public bool DisplayFonts { get; set; }
  /// <summary>
  /// Gets or sets the `DisableCustomize` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.disablecustomize?view=office-pia"/>
  public bool DisableCustomize { get; set; }
  /// <summary>
  /// Gets or sets the `DisableAskAQuestionDropdown` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.disableaskaquestiondropdown?view=office-pia"/>
  public bool DisableAskAQuestionDropdown { get; set; }
}

