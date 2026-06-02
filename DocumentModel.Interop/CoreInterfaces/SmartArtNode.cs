
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SmartArtNode` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode?view=office-pia"/>
public interface ISmartArtNode: IInteropObject
{
  /// <summary>
  /// Gets or sets the `OrgChartLayout` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.orgchartlayout?view=office-pia"/>
  public OrgChartLayoutType OrgChartLayout { get; set; }
  /// <summary>
  /// Gets the `Shapes` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.shapes?view=office-pia"/>
  public ShapeRange Shapes { get; }
  /// <summary>
  /// Gets the `TextFrame2` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.textframe2?view=office-pia"/>
  public TextFrame2 TextFrame2 { get; }
  /// <summary>
  /// Gets the `Level` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.level?view=office-pia"/>
  public int Level { get; }
  /// <summary>
  /// Gets the `Hidden` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.hidden?view=office-pia"/>
  public TriState Hidden { get; }
  /// <summary>
  /// Gets the `Nodes` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.nodes?view=office-pia"/>
  public SmartArtNodes Nodes { get; }
  /// <summary>
  /// Gets the `ParentNode` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.parentnode?view=office-pia"/>
  public SmartArtNode ParentNode { get; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.type?view=office-pia"/>
  public SmartArtNodeType Type { get; }


  #region methods

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

  #endregion methods
}

