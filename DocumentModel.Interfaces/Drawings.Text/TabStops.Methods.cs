namespace DocumentModel.Drawings.Text;

/// <summary>
/// Represents the `TabStops2` interface.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstops2?view=office-pia"/>
public partial interface ITabStops : IModelObject
{
  /// <summary>
  /// Invokes `Item`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstops2.item?view=office-pia"/>
  public ITabStop Item(object Index);
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="Position">The `Position` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstops2.add?view=office-pia"/>
  public ITabStop Add(TabStopType Type, float Position);
}

