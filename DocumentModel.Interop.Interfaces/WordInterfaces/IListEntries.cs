namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents all list entry objects in a drop-down form field.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listentries?view=word-pia"/>
public interface IListEntries : IInteropObject, IInteropCollection<IListEntry>
{


  #region methods

/// <summary>
  /// Adds an item to a drop-down form field.
  /// </summary>
  /// <param name="name">The name of the item to add.</param>
  /// <param name="index">The position for the item in the list.</param>
  /// <returns>The added list entry.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listentries.add?view=word-pia"/>
  public IListEntry Add(string name, object index);

  #endregion methods
}
