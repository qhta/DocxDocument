
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible?view=office-pia
/// </remarks>
public partial interface IAccessible
{
  /// <summary>
  /// Gets the parent accessible object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accparent?view=office-pia
  /// </remarks>
  public object accParent { get; }
  /// <summary>
  /// Gets the number of accessible child objects.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accchildcount?view=office-pia
  /// </remarks>
  public int accChildCount { get; }
  /// <summary>
  /// Gets an accessible child object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accchild?view=office-pia
  /// </remarks>
  public object accChild { get; }
  /// <summary>
  /// Gets or sets the accessible name of the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accname?view=office-pia
  /// </remarks>
  public string accName { get; set; }
  /// <summary>
  /// Gets or sets the accessible value of the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accvalue?view=office-pia
  /// </remarks>
  public string accValue { get; set; }
  /// <summary>
  /// Gets the accessible description of the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accdescription?view=office-pia
  /// </remarks>
  public string accDescription { get; }
  /// <summary>
  /// Gets the accessible role of the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accrole?view=office-pia
  /// </remarks>
  public object accRole { get; }
  /// <summary>
  /// Gets the accessible state of the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accstate?view=office-pia
  /// </remarks>
  public object accState { get; }
  /// <summary>
  /// Gets the help string for the accessible object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acchelp?view=office-pia
  /// </remarks>
  public string accHelp { get; }
  /// <summary>
  /// Gets the help topic identifier for the accessible object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acchelptopic?view=office-pia
  /// </remarks>
  public int accHelpTopic { get; }
  /// <summary>
  /// Gets the keyboard shortcut for the accessible object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acckeyboardshortcut?view=office-pia
  /// </remarks>
  public string accKeyboardShortcut { get; }
  /// <summary>
  /// Gets the object that has keyboard focus.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accfocus?view=office-pia
  /// </remarks>
  public object accFocus { get; }
  /// <summary>
  /// Gets the current selection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accselection?view=office-pia
  /// </remarks>
  public object accSelection { get; }
  /// <summary>
  /// Gets the default action description for the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accdefaultaction?view=office-pia
  /// </remarks>
  public string accDefaultAction { get; }
}
