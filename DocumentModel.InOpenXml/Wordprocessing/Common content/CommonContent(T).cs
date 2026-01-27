namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a common content wrapper for a collection item of the specified type in the WordprocessingML document model.
///   Enables advanced content modeling and extensibility for shared or reusable content elements.
/// </summary>
/// <typeparam name="T">The type of collection item being wrapped, which must implement <see cref="ICollectionItem"/>.</typeparam>
public class CommonContent<T> : CollectionItem where T : ICollectionItem
{
}
