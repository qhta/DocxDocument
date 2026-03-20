
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj?view=office-pia
/// </remarks>
public partial interface _IMsoOleAccDispObj: IAccessible
{
  /// <summary>
  /// Gets or sets the `accParent` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accparent?view=office-pia
  /// </remarks>
  public new object accParent { get; }
  /// <summary>
  /// Gets the `accChildCount` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accchildcount?view=office-pia
  /// </remarks>
  public new int accChildCount { get; }
  /// <summary>
  /// Gets the `accChild` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accchild?view=office-pia
  /// </remarks>
  public new object accChild { get; }
  /// <summary>
  /// Gets or sets the `accName` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accname?view=office-pia
  /// </remarks>
  public new string accName { get; set; }
  /// <summary>
  /// Gets or sets the `accValue` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accvalue?view=office-pia
  /// </remarks>
  public new string accValue { get; set; }
  /// <summary>
  /// Gets the `accDescription` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accdescription?view=office-pia
  /// </remarks>
  public new string accDescription { get; }
  /// <summary>
  /// Gets the `accRole` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accrole?view=office-pia
  /// </remarks>
  public new object accRole { get; }
  /// <summary>
  /// Gets the `accState` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accstate?view=office-pia
  /// </remarks>
  public new object accState { get; }
  /// <summary>
  /// Gets the `accHelp` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.acchelp?view=office-pia
  /// </remarks>
  public new string accHelp { get; }
  /// <summary>
  /// Gets the `accHelpTopic` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.acchelptopic?view=office-pia
  /// </remarks>
  public new int accHelpTopic { get; }
  /// <summary>
  /// Gets the `accKeyboardShortcut` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.acckeyboardshortcut?view=office-pia
  /// </remarks>
  public new string accKeyboardShortcut { get; }
  /// <summary>
  /// Gets the `accFocus` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accfocus?view=office-pia
  /// </remarks>
  public new object accFocus { get; }
  /// <summary>
  /// Gets the `accSelection` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accselection?view=office-pia
  /// </remarks>
  public new object accSelection { get; }
  /// <summary>
  /// Gets the `accDefaultAction` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accdefaultaction?view=office-pia
  /// </remarks>
  public new string accDefaultAction { get; }
}
