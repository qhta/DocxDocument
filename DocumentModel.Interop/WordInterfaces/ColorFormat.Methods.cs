namespace DocumentModel.Interop;

public partial interface ColorFormat
{
  /// <summary>
  /// Returns the ink value for the specified CMYK component.
  /// </summary>
  /// <param name="Index">The index of the CMYK ink component.</param>
  /// <returns>The ink value for the specified component.</returns>
  public float get_Ink(int Index);

  /// <summary>
  /// Sets the color by using CMYK component values.
  /// </summary>
  /// <param name="Cyan">The cyan component value.</param>
  /// <param name="Magenta">The magenta component value.</param>
  /// <param name="Yellow">The yellow component value.</param>
  /// <param name="Black">The black (key) component value.</param>
  public void SetCMYK(int Cyan, int Magenta, int Yellow, int Black);
}
