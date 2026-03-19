namespace DocumentModel.Interop.Word;

public partial interface TableStyle
{
  /// <summary>
  /// Returns the conditional style for the specified table condition code.
  /// </summary>
  /// <param name="ConditionCode">The condition code for which to retrieve the style.</param>
  /// <returns>The <see cref="ConditionalStyle"/> for the specified condition.</returns>
  public ConditionalStyle Condition(WdConditionCode ConditionCode);
}
