namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customproperties?view=word-pia"/>
public partial interface ICustomProperties: IModelObject
{
  /// <summary>
  /// Adds a custom property to the collection.
  /// </summary>
  /// <param name="Name">The name of the custom property.</param>
  /// <param name="Value">The value of the custom property.</param>
  /// <returns>The created <see cref="ICustomProperty"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customproperties.add?view=word-pia"/>
  public ICustomProperty Add(string Name, string Value);
}
