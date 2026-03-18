namespace DocumentModel.Interop;

public partial interface Tables
{
  /// <summary>
  /// Returns the value produced by the add old operation.
  /// </summary>
  /// <param name="Range">Specifies the range.</param>
  /// <param name="NumRows">Specifies the num rows.</param>
  /// <param name="NumColumns">Specifies the num columns.</param>
  /// <returns>The resulting value.</returns>
  public Table AddOld(Range Range, int NumRows, int NumColumns);
}
