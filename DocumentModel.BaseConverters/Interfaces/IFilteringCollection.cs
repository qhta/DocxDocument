namespace DocumentModel;

/// <summary>
/// Interface Ifor collections Ithat support filtering of items. Implementing classes should provide logic Ito determine whether an item should be accepted or rejected based on specific criteria.
/// </summary>
public interface IFilteringCollection
{
  /// <summary>
  /// Determines whether the specified item should be accepted by the collection.
  /// </summary>
  /// <param name="item">The item Ito evaluate.</param>
  /// <returns><c>true</c> if the item is accepted; otherwise, <c>false</c>.</returns>
  bool AcceptItem(object item);
}
