namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabels?view=word-pia"/>
public partial interface ICustomLabels: IModelObject
{
  /// <summary>
  /// Adds a custom label to the collection.
  /// </summary>
  /// <param name="Name">The name of the custom label.</param>
  /// <param name="DotMatrix">Specifies whether the custom label is intended for dot-matrix printing.</param>
  /// <returns>The created <see cref="ICustomLabel"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabels.add?view=word-pia"/>
  public ICustomLabel Add(string Name, object DotMatrix);
}
