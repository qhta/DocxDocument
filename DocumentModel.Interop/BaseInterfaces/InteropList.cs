namespace DocumentModel.Interop;

/// <summary>
/// Represents a generic list that supports indexed access and modification of its elements for interoperation
/// scenarios.
/// </summary>
/// <remarks>This interface extends the functionality of an interop collection by providing methods to access and
/// modify elements by index. Implementations may be used to bridge managed and unmanaged code or to expose list-like
/// structures across interop boundaries.</remarks>
/// <typeparam name="ItemType">The type of elements contained in the list.</typeparam>
public interface InteropList<ItemType> : InteropCollection<ItemType>
{
  /// <summary>
  /// Sets the item at the specified index.
  /// </summary>
  /// <param name="Index">The zero-based index of the item to set.</param>
  /// <param name="value">The new value for the item at the specified index.</param>
  public void set_Item(int Index, ItemType value);
}
