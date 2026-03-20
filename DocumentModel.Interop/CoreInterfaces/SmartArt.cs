
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SmartArt` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SmartArt: InteropObject
{
  /// <summary>
  /// Gets or sets the `AllNodes` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart.allnodes?view=office-pia
  /// </remarks>
  public SmartArtNodes AllNodes { get; }
  /// <summary>
  /// Gets the `Nodes` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart.nodes?view=office-pia
  /// </remarks>
  public SmartArtNodes Nodes { get; }
  /// <summary>
  /// Gets or sets the `Layout` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart.layout?view=office-pia
  /// </remarks>
  public SmartArtLayout Layout { get; set; }
  /// <summary>
  /// Gets or sets the `QuickStyle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart.quickstyle?view=office-pia
  /// </remarks>
  public SmartArtQuickStyle QuickStyle { get; set; }
  /// <summary>
  /// Gets or sets the `Color` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart.color?view=office-pia
  /// </remarks>
  public SmartArtColor Color { get; set; }
  /// <summary>
  /// Gets or sets the `Reverse` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart.reverse?view=office-pia
  /// </remarks>
  public MsoTriState Reverse { get; set; }
}
