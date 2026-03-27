
namespace DocumentModel.Application;

/// <summary>
/// Represents the `SmartArtNode` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode?view=office-pia"/>
public partial interface SmartArtNode: InteropObject
{
  /// <summary>
  /// Invokes `AddNode`.
  /// </summary>
  /// <param name="Position">The `Position` parameter.</param>
  /// <param name="Type">The `Type` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.addnode?view=office-pia"/>
  public SmartArtNode AddNode
  (SmartArtNodePosition Position,
    SmartArtNodeType Type);
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.delete?view=office-pia"/>
  public void Delete();
  /// <summary>
  /// Invokes `Promote`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.promote?view=office-pia"/>
  public void Promote();
  /// <summary>
  /// Invokes `Demote`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.demote?view=office-pia"/>
  public void Demote();
  /// <summary>
  /// Invokes `Larger`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.larger?view=office-pia"/>
  public void Larger();
  /// <summary>
  /// Invokes `Smaller`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.smaller?view=office-pia"/>
  public void Smaller();
  /// <summary>
  /// Invokes `ReorderUp`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.reorderup?view=office-pia"/>
  public void ReorderUp();
  /// <summary>
  /// Invokes `ReorderDown`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.reorderdown?view=office-pia"/>
  public void ReorderDown();
}

