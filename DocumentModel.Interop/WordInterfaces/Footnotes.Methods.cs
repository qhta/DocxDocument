namespace DocumentModel.Interop;

public partial interface Footnotes
{
  /// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="Range">Specifies the range.</param>
  /// <param name="Reference">Specifies the reference.</param>
  /// <param name="Text">Specifies the text.</param>
  /// <returns>The resulting value.</returns>
  public Footnote Add(Range Range, object Reference, object Text);
}
