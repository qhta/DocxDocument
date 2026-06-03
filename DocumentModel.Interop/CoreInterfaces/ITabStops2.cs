using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TabStops2` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstops2?view=office-pia"/>
public interface ITabStops2: IInteropCollection<ITabStop2>
{
  /// <summary>
  /// Gets or sets the `DefaultSpacing` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstops2.defaultspacing?view=office-pia"/>
  public float DefaultSpacing { get; set; }


  #region methods

/// <summary>
  /// Invokes `Item`.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstops2.item?view=office-pia"/>
  public ITabStop2 Item(object index);
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="type">The `Type` parameter.</param>
  /// <param name="position">The `Position` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstops2.add?view=office-pia"/>
  public ITabStop2 Add(TabStopType type, float position);

  #endregion methods
}

