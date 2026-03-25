namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction?view=word-pia"/>
public partial interface SmartTagAction: InteropObject
{
  /// <summary>
  /// Performs the specified smart tag action.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.execute?view=word-pia"/>
  public void Execute();
}
