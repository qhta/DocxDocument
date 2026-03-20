
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SmartArtNode` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SmartArtNode
{
  /// <summary>
  /// Invokes `AddNode`.
  /// </summary>
  /// <param name="Position">The `Position` parameter.</param>
  /// <param name="Type">The `Type` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.addnode?view=office-pia
  /// </remarks>
  public SmartArtNode AddNode
  (MsoSmartArtNodePosition Position,
    MsoSmartArtNodeType Type);
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.delete?view=office-pia
  /// </remarks>
  public void Delete();
  /// <summary>
  /// Invokes `Promote`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.promote?view=office-pia
  /// </remarks>
  public void Promote();
  /// <summary>
  /// Invokes `Demote`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.demote?view=office-pia
  /// </remarks>
  public void Demote();
  /// <summary>
  /// Invokes `Larger`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.larger?view=office-pia
  /// </remarks>
  public void Larger();
  /// <summary>
  /// Invokes `Smaller`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.smaller?view=office-pia
  /// </remarks>
  public void Smaller();
  /// <summary>
  /// Invokes `ReorderUp`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.reorderup?view=office-pia
  /// </remarks>
  public void ReorderUp();
  /// <summary>
  /// Invokes `ReorderDown`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.reorderdown?view=office-pia
  /// </remarks>
  public void ReorderDown();
}
