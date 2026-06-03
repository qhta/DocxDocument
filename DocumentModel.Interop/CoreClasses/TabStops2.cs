using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TabStops2` class.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstops2?view=office-pia"/>
public partial class TabStops2: InteropCollection<TabStop2>
{
  /// <summary>
  /// Gets or sets the `DefaultSpacing` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstops2.defaultspacing?view=office-pia"/>
  public float DefaultSpacing { get; set; }


  #region methods

/// <summary>
  /// Invokes `Item`.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstops2.item?view=office-pia"/>
  public TabStop2 Item(object index) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="type">The `Type` parameter.</param>
  /// <param name="position">The `Position` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstops2.add?view=office-pia"/>
  public TabStop2 Add(TabStopType type, float position) { throw new NotImplementedException(); }

  #endregion methods
}

