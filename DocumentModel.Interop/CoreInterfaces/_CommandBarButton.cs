
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `_CommandBarButton` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton?view=office-pia` for Office interop details.
/// </remarks>
public partial interface _CommandBarButton: CommandBarControl
{
  /// <summary>
  /// Gets or sets the `accParent` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accparent?view=office-pia
  /// </remarks>
  public new object accParent { get; }
  /// <summary>
  /// Gets the `accChildCount` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accchildcount?view=office-pia
  /// </remarks>
  public new int accChildCount { get; }
  /// <summary>
  /// Gets the `accChild` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accchild?view=office-pia
  /// </remarks>
  public new object accChild { get; }
  /// <summary>
  /// Gets or sets the `accName` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accname?view=office-pia
  /// </remarks>
  public new string accName { get; set; }
  /// <summary>
  /// Gets or sets the `accValue` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accvalue?view=office-pia
  /// </remarks>
  public new string accValue { get; set; }
  /// <summary>
  /// Gets the `accDescription` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accdescription?view=office-pia
  /// </remarks>
  public new string accDescription { get; }
  /// <summary>
  /// Gets the `accRole` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accrole?view=office-pia
  /// </remarks>
  public new object accRole { get; }
  /// <summary>
  /// Gets the `accState` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accstate?view=office-pia
  /// </remarks>
  public new object accState { get; }
  /// <summary>
  /// Gets the `accHelp` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.acchelp?view=office-pia
  /// </remarks>
  public new string accHelp { get; }
  /// <summary>
  /// Gets the `accHelpTopic` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.acchelptopic?view=office-pia
  /// </remarks>
  public new int accHelpTopic { get; }
  /// <summary>
  /// Gets the `accKeyboardShortcut` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.acckeyboardshortcut?view=office-pia
  /// </remarks>
  public new string accKeyboardShortcut { get; }
  /// <summary>
  /// Gets the `accFocus` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accfocus?view=office-pia
  /// </remarks>
  public new object accFocus { get; }
  /// <summary>
  /// Gets the `accSelection` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accselection?view=office-pia
  /// </remarks>
  public new object accSelection { get; }
  /// <summary>
  /// Gets the `accDefaultAction` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accdefaultaction?view=office-pia
  /// </remarks>
  public new string accDefaultAction { get; }
  /// <summary>
  /// Gets or sets the `BeginGroup` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.begingroup?view=office-pia
  /// </remarks>
  public new bool BeginGroup { get; set; }
  /// <summary>
  /// Gets the `BuiltIn` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.builtin?view=office-pia
  /// </remarks>
  public new bool BuiltIn { get; }
  /// <summary>
  /// Gets or sets the `Caption` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.caption?view=office-pia
  /// </remarks>
  public new string Caption { get; set; }
  /// <summary>
  /// Gets the `Control` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.control?view=office-pia
  /// </remarks>
  public new object Control { get; }
  /// <summary>
  /// Gets or sets the `DescriptionText` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.descriptiontext?view=office-pia
  /// </remarks>
  public new string DescriptionText { get; set; }
  /// <summary>
  /// Gets or sets the `Enabled` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.enabled?view=office-pia
  /// </remarks>
  public new bool Enabled { get; set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.height?view=office-pia
  /// </remarks>
  public new int Height { get; set; }
  /// <summary>
  /// Gets or sets the `HelpContextId` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.helpcontextid?view=office-pia
  /// </remarks>
  public new int HelpContextId { get; set; }
  /// <summary>
  /// Gets or sets the `HelpFile` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.helpfile?view=office-pia
  /// </remarks>
  public new string HelpFile { get; set; }
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.id?view=office-pia
  /// </remarks>
  public new int Id { get; }
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.index?view=office-pia
  /// </remarks>
  public new int Index { get; }
  /// <summary>
  /// Gets the `InstanceId` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.instanceid?view=office-pia
  /// </remarks>
  public new int InstanceId { get; }
  /// <summary>
  /// Gets the `Left` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.left?view=office-pia
  /// </remarks>
  public new int Left { get; }
  /// <summary>
  /// Gets or sets the `OLEUsage` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.oleusage?view=office-pia
  /// </remarks>
  public new MsoControlOLEUsage OLEUsage { get; set; }
  /// <summary>
  /// Gets or sets the `OnAction` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.onaction?view=office-pia
  /// </remarks>
  public new string OnAction { get; set; }
  /// <summary>
  /// Gets or sets the `Parameter` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.parameter?view=office-pia
  /// </remarks>
  public new string Parameter { get; set; }
  /// <summary>
  /// Gets or sets the `Priority` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.priority?view=office-pia
  /// </remarks>
  public new int Priority { get; set; }
  /// <summary>
  /// Gets or sets the `Tag` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.tag?view=office-pia
  /// </remarks>
  public new string Tag { get; set; }
  /// <summary>
  /// Gets or sets the `TooltipText` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.tooltiptext?view=office-pia
  /// </remarks>
  public new string TooltipText { get; set; }
  /// <summary>
  /// Gets the `Top` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.top?view=office-pia
  /// </remarks>
  public new int Top { get; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.type?view=office-pia
  /// </remarks>
  public new MsoControlType Type { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.visible?view=office-pia
  /// </remarks>
  public new bool Visible { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.width?view=office-pia
  /// </remarks>
  public new int Width { get; set; }
  /// <summary>
  /// Gets the `IsPriorityDropped` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.isprioritydropped?view=office-pia
  /// </remarks>
  public new bool IsPriorityDropped { get; }
  /// <summary>
  /// Gets or sets the `BuiltInFace` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.builtinface?view=office-pia
  /// </remarks>
  public bool BuiltInFace { get; set; }
  /// <summary>
  /// Gets or sets the `FaceId` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.faceid?view=office-pia
  /// </remarks>
  public int FaceId { get; set; }
  /// <summary>
  /// Gets or sets the `ShortcutText` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.shortcuttext?view=office-pia
  /// </remarks>
  public string ShortcutText { get; set; }
  /// <summary>
  /// Gets or sets the `State` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.state?view=office-pia
  /// </remarks>
  public MsoButtonState State { get; set; }
  /// <summary>
  /// Gets or sets the `Style` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.style?view=office-pia
  /// </remarks>
  public MsoButtonStyle Style { get; set; }
  /// <summary>
  /// Gets or sets the `HyperlinkType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.hyperlinktype?view=office-pia
  /// </remarks>
  public MsoCommandBarButtonHyperlinkType HyperlinkType { get; set; }
  /// <summary>
  /// Gets or sets the `Picture` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.picture?view=office-pia
  /// </remarks>
  public object Picture { get; set; }
  /// <summary>
  /// Gets or sets the `Mask` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.mask?view=office-pia
  /// </remarks>
  public object Mask { get; set; }
  /// <summary>
  /// Gets the `InstanceIdPtr` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.instanceidptr?view=office-pia
  /// </remarks>
  public object InstanceIdPtr { get; }
}
