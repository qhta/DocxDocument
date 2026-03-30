namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes?view=word-pia"/>
public partial interface Endnotes: IModelObject
{
  /// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="Range">Specifies the range.</param>
  /// <param name="Reference">Specifies the reference.</param>
  /// <param name="Text">Specifies the text.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.add?view=word-pia"/>
  public Endnote Add(Range Range, object Reference, object Text);
}
