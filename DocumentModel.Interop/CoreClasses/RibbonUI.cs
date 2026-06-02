
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the Ribbon UI object returned by the `onLoad` procedure.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui?view=office-pia"/>
public partial class RibbonUI
{


  #region methods

/// <summary>
  /// Invalidates cached values for all Ribbon controls.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.invalidate?view=office-pia"/>
  public void Invalidate() { throw new NotImplementedException(); }
  /// <summary>
  /// Invalidates the cached value for a specific Ribbon control.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.invalidatecontrol?view=office-pia"/>
  public void InvalidateControl(string ControlID) { throw new NotImplementedException(); }
  /// <summary>
  /// Invalidates a built-in Ribbon control.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.invalidatecontrolmso?view=office-pia"/>
  public void InvalidateControlMso(string ControlID) { throw new NotImplementedException(); }
  /// <summary>
  /// Activates the specified custom tab.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.activatetab?view=office-pia"/>
  public void ActivateTab(string ControlID) { throw new NotImplementedException(); }
  /// <summary>
  /// Activates the specified built-in tab.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.activatetabmso?view=office-pia"/>
  public void ActivateTabMso(string ControlID) { throw new NotImplementedException(); }
  /// <summary>
  /// Activates a specified custom tab using its qualified name.
  /// </summary>
  /// <param name="ControlID">The `ControlID` parameter.</param>
  /// <param name="Namespace">The `Namespace` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonui.activatetabq?view=office-pia"/>
  public void ActivateTabQ(string ControlID, string Namespace) { throw new NotImplementedException(); }

  #endregion methods
}


