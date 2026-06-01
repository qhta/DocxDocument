using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a custom task pane in the container application.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane?view=office-pia"/>
public partial class _CustomTaskPane
{
  /// <summary>
  /// Gets or sets the `Title` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane.title?view=office-pia"/>
  public string Title { get; }
  /// <summary>
  /// Gets the `Window` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane.window?view=office-pia"/>
  public object Window { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane.visible?view=office-pia"/>
  public bool Visible { get; set; }
  /// <summary>
  /// Gets the `ContentControl` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane.contentcontrol?view=office-pia"/>
  public object ContentControl { get; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane.height?view=office-pia"/>
  public int Height { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane.width?view=office-pia"/>
  public int Width { get; set; }
  /// <summary>
  /// Gets or sets the `DockPosition` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane.dockposition?view=office-pia"/>
  public CTPDockPosition DockPosition { get; set; }
  /// <summary>
  /// Gets or sets the `DockPositionRestrict` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpane.dockpositionrestrict?view=office-pia"/>
  public CTPDockPositionRestrict DockPositionRestrict { get; set; }
}

