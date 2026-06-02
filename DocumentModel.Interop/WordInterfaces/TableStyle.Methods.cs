namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle?view=word-pia"/>
public partial interface ITableStyle
{
  /// <summary>
  /// Returns the conditional style for the specified table condition code.
  /// </summary>
  /// <param name="ConditionCode">The condition code for which to retrieve the style.</param>
  /// <returns>The <see cref="ConditionalStyle"/> for the specified condition.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.condition?view=word-pia"/>
  public ConditionalStyle Condition(ConditionCode ConditionCode);
}
