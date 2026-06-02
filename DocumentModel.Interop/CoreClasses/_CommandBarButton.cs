
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `_CommandBarButton` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton?view=office-pia` for Office interop details.
/// </remarks>
public partial class _CommandBarButton: CommandBarControl
{
  /// <summary>
  /// Gets or sets the `accParent` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accparent?view=office-pia"/>
  public new object accParent { get; }
  /// <summary>
  /// Gets the `accChildCount` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accchildcount?view=office-pia"/>
  public new int accChildCount { get; }
  /// <summary>
  /// Gets the `accChild` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accchild?view=office-pia"/>
  public new object accChild { get; }
  /// <summary>
  /// Gets or sets the `accName` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accname?view=office-pia"/>
  public new string accName { get; set; }
  /// <summary>
  /// Gets or sets the `accValue` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accvalue?view=office-pia"/>
  public new string accValue { get; set; }
  /// <summary>
  /// Gets the `accDescription` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accdescription?view=office-pia"/>
  public new string accDescription { get; }
  /// <summary>
  /// Gets the `accRole` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accrole?view=office-pia"/>
  public new object accRole { get; }
  /// <summary>
  /// Gets the `accState` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accstate?view=office-pia"/>
  public new object accState { get; }
  /// <summary>
  /// Gets the `accHelp` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.acchelp?view=office-pia"/>
  public new string accHelp { get; }
  /// <summary>
  /// Gets the `accHelpTopic` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.acchelptopic?view=office-pia"/>
  public new int accHelpTopic { get; }
  /// <summary>
  /// Gets the `accKeyboardShortcut` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.acckeyboardshortcut?view=office-pia"/>
  public new string accKeyboardShortcut { get; }
  /// <summary>
  /// Gets the `accFocus` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accfocus?view=office-pia"/>
  public new object accFocus { get; }
  /// <summary>
  /// Gets the `accSelection` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accselection?view=office-pia"/>
  public new object accSelection { get; }
  /// <summary>
  /// Gets the `accDefaultAction` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accdefaultaction?view=office-pia"/>
  public new string accDefaultAction { get; }
  /// <summary>
  /// Gets or sets the `BeginGroup` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.begingroup?view=office-pia"/>
  public new bool BeginGroup { get; set; }
  /// <summary>
  /// Gets the `BuiltIn` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.builtin?view=office-pia"/>
  public new bool BuiltIn { get; }
  /// <summary>
  /// Gets or sets the `Caption` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.caption?view=office-pia"/>
  public new string Caption { get; set; }
  /// <summary>
  /// Gets the `Control` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.control?view=office-pia"/>
  public new object Control { get; }
  /// <summary>
  /// Gets or sets the `DescriptionText` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.descriptiontext?view=office-pia"/>
  public new string DescriptionText { get; set; }
  /// <summary>
  /// Gets or sets the `Enabled` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.enabled?view=office-pia"/>
  public new bool Enabled { get; set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.height?view=office-pia"/>
  public new int Height { get; set; }
  /// <summary>
  /// Gets or sets the `HelpContextId` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.helpcontextid?view=office-pia"/>
  public new int HelpContextId { get; set; }
  /// <summary>
  /// Gets or sets the `HelpFile` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.helpfile?view=office-pia"/>
  public new string HelpFile { get; set; }
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.id?view=office-pia"/>
  public new int Id { get; }
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.index?view=office-pia"/>
  public new int Index { get; }
  /// <summary>
  /// Gets the `InstanceId` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.instanceid?view=office-pia"/>
  public new int InstanceId { get; }
  /// <summary>
  /// Gets the `Left` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.left?view=office-pia"/>
  public new int Left { get; }
  /// <summary>
  /// Gets or sets the `OLEUsage` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.oleusage?view=office-pia"/>
  public new ControlOLEUsage OLEUsage { get; set; }
  /// <summary>
  /// Gets or sets the `OnAction` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.onaction?view=office-pia"/>
  public new string OnAction { get; set; }
  /// <summary>
  /// Gets or sets the `Parameter` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.parameter?view=office-pia"/>
  public new string Parameter { get; set; }
  /// <summary>
  /// Gets or sets the `Priority` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.priority?view=office-pia"/>
  public new int Priority { get; set; }
  /// <summary>
  /// Gets or sets the `Tag` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.tag?view=office-pia"/>
  public new string Tag { get; set; }
  /// <summary>
  /// Gets or sets the `TooltipText` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.tooltiptext?view=office-pia"/>
  public new string TooltipText { get; set; }
  /// <summary>
  /// Gets the `Top` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.top?view=office-pia"/>
  public new int Top { get; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.type?view=office-pia"/>
  public new ControlType Type { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.visible?view=office-pia"/>
  public new bool Visible { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.width?view=office-pia"/>
  public new int Width { get; set; }
  /// <summary>
  /// Gets the `IsPriorityDropped` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.isprioritydropped?view=office-pia"/>
  public new bool IsPriorityDropped { get; }
  /// <summary>
  /// Gets or sets the `BuiltInFace` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.builtinface?view=office-pia"/>
  public bool BuiltInFace { get; set; }
  /// <summary>
  /// Gets or sets the `FaceId` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.faceid?view=office-pia"/>
  public int FaceId { get; set; }
  /// <summary>
  /// Gets or sets the `ShortcutText` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.shortcuttext?view=office-pia"/>
  public string ShortcutText { get; set; }
  /// <summary>
  /// Gets or sets the `State` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.state?view=office-pia"/>
  public ButtonState State { get; set; }
  /// <summary>
  /// Gets or sets the `Style` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.style?view=office-pia"/>
  public ButtonStyle Style { get; set; }
  /// <summary>
  /// Gets or sets the `HyperlinkType` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.hyperlinktype?view=office-pia"/>
  public CommandBarButtonHyperlinkType HyperlinkType { get; set; }
  /// <summary>
  /// Gets or sets the `Picture` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.picture?view=office-pia"/>
  public object Picture { get; set; }
  /// <summary>
  /// Gets or sets the `Mask` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.mask?view=office-pia"/>
  public object Mask { get; set; }
  /// <summary>
  /// Gets the `InstanceIdPtr` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.instanceidptr?view=office-pia"/>
  public object InstanceIdPtr { get; }


  #region methods

/// <summary>
  /// Invokes `accSelect`.
  /// </summary>
  /// <param name="flagsSelect">The `flagsSelect` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accselect?view=office-pia"/>
  public new void accSelect(int flagsSelect, object varChild) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `accLocation`.
  /// </summary>
  /// <param name="pxLeft">The `pxLeft` parameter.</param>
  /// <param name="pyTop">The `pyTop` parameter.</param>
  /// <param name="pcxWidth">The `pcxWidth` parameter.</param>
  /// <param name="pcyHeight">The `pcyHeight` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.acclocation?view=office-pia"/>
  public new void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `accNavigate`.
  /// </summary>
  /// <param name="navDir">The `navDir` parameter.</param>
  /// <param name="varStart">The `varStart` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accnavigate?view=office-pia"/>
  public new object accNavigate(int navDir, object varStart) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `accHitTest`.
  /// </summary>
  /// <param name="xLeft">The `xLeft` parameter.</param>
  /// <param name="yTop">The `yTop` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.acchittest?view=office-pia"/>
  public new object accHitTest(int xLeft, int yTop) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `accDoDefaultAction`.
  /// </summary>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accdodefaultaction?view=office-pia"/>
  public new void accDoDefaultAction(object varChild) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Copy`.
  /// </summary>
  /// <param name="Bar">The `Bar` parameter.</param>
  /// <param name="Before">The `Before` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.copy?view=office-pia"/>
  public new CommandBarControl Copy(object Bar, object Before) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <param name="Temporary">The `Temporary` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.delete?view=office-pia"/>
  public new void Delete(object Temporary) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Execute`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.execute?view=office-pia"/>
  public new void Execute() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Move`.
  /// </summary>
  /// <param name="Bar">The `Bar` parameter.</param>
  /// <param name="Before">The `Before` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.move?view=office-pia"/>
  public new CommandBarControl Move(object Bar, object Before) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reset`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.reset?view=office-pia"/>
  public new void Reset() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetFocus`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.setfocus?view=office-pia"/>
  public new void SetFocus() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved1`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.reserved1?view=office-pia"/>
  public new void Reserved1() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved2`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.reserved2?view=office-pia"/>
  public new void Reserved2() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved3`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.reserved3?view=office-pia"/>
  public new void Reserved3() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved4`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.reserved4?view=office-pia"/>
  public new void Reserved4() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved5`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.reserved5?view=office-pia"/>
  public new void Reserved5() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved6`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.reserved6?view=office-pia"/>
  public new void Reserved6() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved7`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.reserved7?view=office-pia"/>
  public new void Reserved7() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `CopyFace`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.copyface?view=office-pia"/>
  public void CopyFace() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `PasteFace`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.pasteface?view=office-pia"/>
  public void PasteFace() { throw new NotImplementedException(); }

  #endregion methods
}

