using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a custom task pane in the container application.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane?view=office-pia
/// </remarks>
public partial interface _CustomTaskPane
{
  /// <summary>
  /// Gets or sets the `Title` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane.title?view=office-pia
  /// </remarks>
  public string Title { get; }
  /// <summary>
  /// Gets the `Window` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane.window?view=office-pia
  /// </remarks>
  public object Window { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane.visible?view=office-pia
  /// </remarks>
  public bool Visible { get; set; }
  /// <summary>
  /// Gets the `ContentControl` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane.contentcontrol?view=office-pia
  /// </remarks>
  public object ContentControl { get; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane.height?view=office-pia
  /// </remarks>
  public int Height { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane.width?view=office-pia
  /// </remarks>
  public int Width { get; set; }
  /// <summary>
  /// Gets or sets the `DockPosition` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane.dockposition?view=office-pia
  /// </remarks>
  public MsoCTPDockPosition DockPosition { get; set; }
  /// <summary>
  /// Gets or sets the `DockPositionRestrict` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane.dockpositionrestrict?view=office-pia
  /// </remarks>
  public MsoCTPDockPositionRestrict DockPositionRestrict { get; set; }
}
