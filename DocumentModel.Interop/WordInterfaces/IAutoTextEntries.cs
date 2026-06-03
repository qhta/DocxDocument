namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of AutoTextEntry objects that represent the AutoText entries in a template.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentries?view=word-pia"/>
public interface IAutoTextEntries : IInteropObject, IInteropCollection<IAutoTextEntry>
{


  #region methods

/// <summary>
  /// Creates a new AutoText entry from the specified range.
  /// </summary>
  /// <param name="Name">The name of the AutoText entry.</param>
  /// <param name="Range">The range whose contents are stored in the AutoText entry.</param>
  /// <returns>The created <see cref="AutoTextEntry"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentries.add?view=word-pia"/>
  public AutoTextEntry Add(string Name, Range Range);

  /// <summary>
  /// Appends the specified range to the Spike AutoText entry.
  /// </summary>
  /// <param name="Range">The range to append to the Spike entry.</param>
  /// <returns>The Spike <see cref="AutoTextEntry"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentries.appendtospike?view=word-pia"/>
  public IAutoTextEntry AppendToSpike(IRange Range);

  #endregion methods
}
