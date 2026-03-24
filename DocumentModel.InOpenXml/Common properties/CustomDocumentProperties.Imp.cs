using DocumentModel.Interop;

namespace DocumentModel;

public partial class CustomDocumentProperties: DIC.DocumentProperties
{

  /// <summary>
  /// Iterates through the collection of document properties, yielding interface to each property one at a time.
  /// </summary>
  /// <returns>Interface to each document property in the collection.</returns>
  IEnumerator<DIC.DocumentProperty> IEnumerable<DIC.DocumentProperty>.GetEnumerator()
  {
    return CustomProperties.GetEnumerator();
  }

  /// <summary>
  /// Implements the non-generic GetEnumerator method of the IEnumerable interface.
  /// </summary>
  /// <returns></returns>
  IEnumerator IEnumerable.GetEnumerator()
  {
    return CustomProperties.GetEnumerator();
  }

  /// <summary>
  /// Provides indexed access to document properties in the collection.
  /// The index can be either an integer, which retrieves the property at the specified position in the collection,
  /// or a string, which retrieves the property with the specified name.
  /// When using a string index, the method looks up the property by its name and returns it if found;
  /// otherwise, it may throw an exception or return null depending on the implementation.
  /// This allows for flexible access to document properties based on either their order in the collection
  /// or their unique names.
  /// </summary>
  /// <param name="Index">The index of the document property to retrieve. Can be an integer or a string.</param>
  /// <returns>The document property at the specified index.</returns>
  DIC.DocumentProperty InteropCollection<DIC.DocumentProperty>.this[object Index]
  {
    get => CustomProperties[Index]; 
    set => CustomProperties[Index] = (CustomProperty)value;
  }
}