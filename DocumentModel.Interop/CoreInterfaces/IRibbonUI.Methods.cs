
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the Ribbon UI object returned by the `onLoad` procedure.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui?view=office-pia
/// </remarks>
public partial interface IRibbonUI
{
  /// <summary>
  /// Invalidates cached values for all Ribbon controls.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.invalidate?view=office-pia
  /// </remarks>
  public void Invalidate();
  /// <summary>
  /// Invalidates the cached value for a specific Ribbon control.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.invalidatecontrol?view=office-pia
  /// </remarks>
  public void InvalidateControl(string ControlID);
  /// <summary>
  /// Invalidates a built-in Ribbon control.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.invalidatecontrolmso?view=office-pia
  /// </remarks>
  public void InvalidateControlMso(string ControlID);
  /// <summary>
  /// Activates the specified custom tab.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.activatetab?view=office-pia
  /// </remarks>
  public void ActivateTab(string ControlID);
  /// <summary>
  /// Activates the specified built-in tab.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.activatetabmso?view=office-pia
  /// </remarks>
  public void ActivateTabMso(string ControlID);
  /// <summary>
  /// Activates a specified custom tab using its qualified name.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <param name="Namespace">The `Namespace` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.activatetabq?view=office-pia
  /// </remarks>
  public void ActivateTabQ(string ControlID, string Namespace);
}
