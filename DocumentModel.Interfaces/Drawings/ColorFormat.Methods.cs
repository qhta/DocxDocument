namespace DocumentModel.Drawings;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat?view=word-pia"/>
public partial interface IColorFormat: IModelObject
{
  /// <summary>
  /// Returns the ink value for the specified CMYK component.
  /// </summary>
  /// <param name="Index">The index of the CMYK ink component.</param>
  /// <returns>The ink value for the specified component.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.get_ink?view=word-pia"/>
  public float Ink(int Index);

  /// <summary>
  /// Sets the color by using CMYK component values.
  /// </summary>
  /// <param name="Cyan">The cyan component value.</param>
  /// <param name="Magenta">The magenta component value.</param>
  /// <param name="Yellow">The yellow component value.</param>
  /// <param name="Black">The black (key) component value.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.setcmyk?view=word-pia"/>
  public void SetCMYK(int Cyan, int Magenta, int Yellow, int Black);
}
