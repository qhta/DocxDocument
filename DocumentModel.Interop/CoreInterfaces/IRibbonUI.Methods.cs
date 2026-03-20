
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IRibbonUI` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IRibbonUI
{
  /// <summary>
  /// Invokes `Invalidate`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.invalidate?view=office-pia
  /// </remarks>
  public void Invalidate();
  /// <summary>
  /// Invokes `InvalidateControl`.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.invalidatecontrol?view=office-pia
  /// </remarks>
  public void InvalidateControl(string ControlID);
  /// <summary>
  /// Invokes `InvalidateControlMso`.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.invalidatecontrolmso?view=office-pia
  /// </remarks>
  public void InvalidateControlMso(string ControlID);
  /// <summary>
  /// Invokes `ActivateTab`.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.activatetab?view=office-pia
  /// </remarks>
  public void ActivateTab(string ControlID);
  /// <summary>
  /// Invokes `ActivateTabMso`.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.activatetabmso?view=office-pia
  /// </remarks>
  public void ActivateTabMso(string ControlID);
  /// <summary>
  /// Invokes `ActivateTabQ`.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <param name="Namespace">The `Namespace` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.activatetabq?view=office-pia
  /// </remarks>
  public void ActivateTabQ(string ControlID, string Namespace);
}
