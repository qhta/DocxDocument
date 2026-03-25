
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the Ribbon UI object returned by the `onLoad` procedure.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui?view=office-pia"/>
public partial interface IRibbonUI
{
  /// <summary>
  /// Invalidates cached values for all Ribbon controls.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.invalidate?view=office-pia"/>
  public void Invalidate();
  /// <summary>
  /// Invalidates the cached value for a specific Ribbon control.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.invalidatecontrol?view=office-pia"/>
  public void InvalidateControl(string ControlID);
  /// <summary>
  /// Invalidates a built-in Ribbon control.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.invalidatecontrolmso?view=office-pia"/>
  public void InvalidateControlMso(string ControlID);
  /// <summary>
  /// Activates the specified custom tab.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.activatetab?view=office-pia"/>
  public void ActivateTab(string ControlID);
  /// <summary>
  /// Activates the specified built-in tab.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.activatetabmso?view=office-pia"/>
  public void ActivateTabMso(string ControlID);
  /// <summary>
  /// Activates a specified custom tab using its qualified name.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <param name="Namespace">The `Namespace` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.activatetabq?view=office-pia"/>
  public void ActivateTabQ(string ControlID, string Namespace);
}

