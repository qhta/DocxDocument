using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of CommandBar objects that represent the command bars in the container application.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars?view=office-pia
/// </remarks>
public partial interface _CommandBars: InteropDictionary<string, CommandBar>
{
  /// <summary>
  /// Gets or sets the `ActionControl` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.actioncontrol?view=office-pia
  /// </remarks>
  public CommandBarControl ActionControl { get; }
  /// <summary>
  /// Gets the `ActiveMenuBar` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.activemenubar?view=office-pia
  /// </remarks>
  public CommandBar ActiveMenuBar { get; }
  /// <summary>
  /// Gets or sets the `DisplayTooltips` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.displaytooltips?view=office-pia
  /// </remarks>
  public bool DisplayTooltips { get; set; }
  /// <summary>
  /// Gets or sets the `DisplayKeysInTooltips` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.displaykeysintooltips?view=office-pia
  /// </remarks>
  public bool DisplayKeysInTooltips { get; set; }
  /// <summary>
  /// Gets or sets the `LargeButtons` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.largebuttons?view=office-pia
  /// </remarks>
  public bool LargeButtons { get; set; }
  /// <summary>
  /// Gets or sets the `MenuAnimationStyle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.menuanimationstyle?view=office-pia
  /// </remarks>
  public MsoMenuAnimation MenuAnimationStyle { get; set; }
  /// <summary>
  /// Gets the `IdsString` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.idsstring?view=office-pia
  /// </remarks>
  public int IdsString { get; }
  /// <summary>
  /// Gets the `TmcGetName` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.tmcgetname?view=office-pia
  /// </remarks>
  public int TmcGetName { get; }
  /// <summary>
  /// Gets or sets the `AdaptiveMenus` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.adaptivemenus?view=office-pia
  /// </remarks>
  public bool AdaptiveMenus { get; set; }
  /// <summary>
  /// Gets or sets the `DisplayFonts` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.displayfonts?view=office-pia
  /// </remarks>
  public bool DisplayFonts { get; set; }
  /// <summary>
  /// Gets or sets the `DisableCustomize` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.disablecustomize?view=office-pia
  /// </remarks>
  public bool DisableCustomize { get; set; }
  /// <summary>
  /// Gets or sets the `DisableAskAQuestionDropdown` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbars.disableaskaquestiondropdown?view=office-pia
  /// </remarks>
  public bool DisableAskAQuestionDropdown { get; set; }
}
