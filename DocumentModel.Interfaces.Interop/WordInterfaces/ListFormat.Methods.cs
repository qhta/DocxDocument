namespace DocumentModel.Interop;

public partial interface ListFormat
{
  /// <summary>
  /// Determines whether the specified list template can continue the previous list.
  /// </summary>
  /// <param name="ListTemplate">The list template to check.</param>
  /// <returns>A <see cref="WdContinue"/> value indicating if the list can continue.</returns>
  public WdContinue CanContinuePreviousList(ListTemplate ListTemplate);
}
