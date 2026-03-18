namespace DocumentModel.Interop;

public partial interface FormFields
{
  /// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="Range">Specifies the range.</param>
  /// <param name="Type">Specifies the type.</param>
  /// <returns>The resulting value.</returns>
  public FormField Add(Range Range, WdFieldType Type);
}
