namespace DocumentModel.Interop.Word;

public partial interface Dialog
{
  /// <summary>
  /// Displays the dialog box and returns a value that indicates which button the user chose.
  /// </summary>
  /// <param name="TimeOut">The time, in milliseconds, before the dialog box is closed automatically.</param>
  /// <returns>An integer value indicating the user's selection.</returns>
  public int Show(object TimeOut);
}
