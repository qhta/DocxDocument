using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.styles?view=word-pia"/>
public partial interface IStyles: IModelObject
{
  /// <summary>
  /// Adds a new style to the collection.
  /// </summary>
  /// <param name="Name">The name of the new style.</param>
  /// <param name="Type">The type of the new style.</param>
  /// <returns>The created <see cref="IStyle"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.styles.add?view=word-pia"/>
  public IStyle Add(string Name, StyleType Type);
}
