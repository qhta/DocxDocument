namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Style objects that represent both the built-in and user-defined styles in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.styles?view=word-pia"/>
public interface IStyles : IInteropObject, IInteropCollection<IStyle>
{


  #region methods

/// <summary>
  /// Adds a new style to the collection.
  /// </summary>
  /// <param name="name">The name of the new style.</param>
  /// <param name="type">The type of the new style.</param>
  /// <returns>The created <see cref="IStyle"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.styles.add?view=word-pia"/>
  public IStyle Add(string name, StyleType type);

  #endregion methods
}
