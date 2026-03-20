
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IAccessible` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IAccessible
{
  /// <summary>
  /// Gets or sets the `accParent` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accparent?view=office-pia
  /// </remarks>
  public object accParent { get; }
  /// <summary>
  /// Gets the `accChildCount` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accchildcount?view=office-pia
  /// </remarks>
  public int accChildCount { get; }
  /// <summary>
  /// Gets the `accChild` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accchild?view=office-pia
  /// </remarks>
  public object accChild { get; }
  /// <summary>
  /// Gets or sets the `accName` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accname?view=office-pia
  /// </remarks>
  public string accName { get; set; }
  /// <summary>
  /// Gets or sets the `accValue` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accvalue?view=office-pia
  /// </remarks>
  public string accValue { get; set; }
  /// <summary>
  /// Gets the `accDescription` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accdescription?view=office-pia
  /// </remarks>
  public string accDescription { get; }
  /// <summary>
  /// Gets the `accRole` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accrole?view=office-pia
  /// </remarks>
  public object accRole { get; }
  /// <summary>
  /// Gets the `accState` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accstate?view=office-pia
  /// </remarks>
  public object accState { get; }
  /// <summary>
  /// Gets the `accHelp` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acchelp?view=office-pia
  /// </remarks>
  public string accHelp { get; }
  /// <summary>
  /// Gets the `accHelpTopic` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acchelptopic?view=office-pia
  /// </remarks>
  public int accHelpTopic { get; }
  /// <summary>
  /// Gets the `accKeyboardShortcut` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acckeyboardshortcut?view=office-pia
  /// </remarks>
  public string accKeyboardShortcut { get; }
  /// <summary>
  /// Gets the `accFocus` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accfocus?view=office-pia
  /// </remarks>
  public object accFocus { get; }
  /// <summary>
  /// Gets the `accSelection` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accselection?view=office-pia
  /// </remarks>
  public object accSelection { get; }
  /// <summary>
  /// Gets the `accDefaultAction` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accdefaultaction?view=office-pia
  /// </remarks>
  public string accDefaultAction { get; }
}
