namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialog?view=word-pia"/>
public partial interface Dialog
{
  /// <summary>
  /// Displays the dialog box and returns a value that indicates which button the user chose.
  /// </summary>
  /// <param name="TimeOut">The time, in milliseconds, before the dialog box is closed automatically.</param>
  /// <returns>An integer value indicating the user's selection.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialog.show?view=word-pia"/>
  public int Show(object TimeOut);
}
