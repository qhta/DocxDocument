namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of TwoInitialCapsException objects that represent all the items listed in the Don't correct box
/// on the INitial CAps tab in the AutoCorrect Exceptions dialog box.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.twoinitialcapsexceptions?view=word-pia"/>
public interface ITwoInitialCapsExceptions : IInteropObject, IInteropCollection<ITwoInitialCapsException>
{


  #region methods

/// <summary>
  /// Adds a new two-initial-caps exception to the collection.
  /// </summary>
  /// <param name="Name">The name of the exception to add.</param>
  /// <returns>The created <see cref="ITwoInitialCapsException"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.twoinitialcapsexceptions.add?view=word-pia"/>
  public ITwoInitialCapsException Add(string Name);

  #endregion methods
}
