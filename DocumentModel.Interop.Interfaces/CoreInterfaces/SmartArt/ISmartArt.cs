
namespace DocumentModel.Interop.Core;	
/// <summary>
/// Represents the `SmartArt` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart?view=office-pia` for Office interop details.
/// </remarks>
public interface ISmartArt: IInteropObject
{
  /// <summary>
  /// Gets the `AllNodes` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart.allnodes?view=office-pia"/>
  public ISmartArtNodes AllNodes { get; }
  /// <summary>
  /// Gets the `Nodes` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart.nodes?view=office-pia"/>
  public ISmartArtNodes Nodes { get; }
  /// <summary>
  /// Gets or sets the `Layout` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart.layout?view=office-pia"/>
  public ISmartArtLayout Layout { get; set; }
  /// <summary>
  /// Gets or sets the `QuickStyle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart.quickstyle?view=office-pia"/>
  public ISmartArtQuickStyle QuickStyle { get; set; }
  /// <summary>
  /// Gets or sets the `Color` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart.color?view=office-pia"/>
  public ISmartArtColor Color { get; set; }
  /// <summary>
  /// Gets or sets the `Reverse` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart.reverse?view=office-pia"/>
  public TriState Reverse { get; set; }	

  #region methods	
/// <summary>
  /// Invokes `Reset`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart.reset?view=office-pia"/>
  public void Reset();	
  #endregion methods
}	
