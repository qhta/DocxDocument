
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible?view=office-pia"/>
public partial class Accessible: IAccessible
{
  /// <summary>
  /// Gets the parent accessible object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accparent?view=office-pia"/>
  public object Parent { get; }
  /// <summary>
  /// Gets the number of accessible child objects.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accchildcount?view=office-pia"/>
  public int ChildCount { get; }
  /// <summary>
  /// Gets an accessible child object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accchild?view=office-pia"/>
  public object Child { get; }
  /// <summary>
  /// Gets or sets the accessible name of the object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accname?view=office-pia"/>
  public string Name { get; set; }
  /// <summary>
  /// Gets or sets the accessible value of the object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accvalue?view=office-pia"/>
  public string Value { get; set; }
  /// <summary>
  /// Gets the accessible description of the object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accdescription?view=office-pia"/>
  public string Description { get; }
  /// <summary>
  /// Gets the accessible role of the object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accrole?view=office-pia"/>
  public object Role { get; }
  /// <summary>
  /// Gets the accessible state of the object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accstate?view=office-pia"/>
  public object State { get; }
  /// <summary>
  /// Gets the help string for the accessible object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acchelp?view=office-pia"/>
  public string Help { get; }
  /// <summary>
  /// Gets the help topic identifier for the accessible object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acchelptopic?view=office-pia"/>
  public int HelpTopic { get; }
  /// <summary>
  /// Gets the keyboard shortcut for the accessible object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acckeyboardshortcut?view=office-pia"/>
  public string KeyboardShortcut { get; }
  /// <summary>
  /// Gets the object that has keyboard focus.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accfocus?view=office-pia"/>
  public object Focus { get; }
  /// <summary>
  /// Gets the current selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accselection?view=office-pia"/>
  public object Selection { get; }
  /// <summary>
  /// Gets the default action description for the object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accdefaultaction?view=office-pia"/>
  public string DefaultAction { get; }
}

