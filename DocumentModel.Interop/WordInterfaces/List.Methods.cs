namespace DocumentModel.Interop;

public partial interface List
{
  /// <summary>
  /// Converts list numbers to text.
  /// </summary>
  /// <param name="NumberType">The type of number format to convert.</param>
  public void ConvertNumbersToText(WdNumberType NumberType);
}
