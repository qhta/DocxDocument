namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a built-in dialog box.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialog?view=word-pia"/>
public partial class Dialog : InteropObject
{
  /// <summary>
  /// Gets or sets the tab that appears by default when the dialog box is displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialog.defaulttab?view=word-pia"/>
  public WordDialogTab DefaultTab { get; set; }

  /// <summary>
  /// Gets the built-in type of the dialog box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialog.type?view=word-pia"/>
  public WordDialog Type { get; set; }

  /// <summary>
  /// Gets the command name associated with the dialog box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialog.commandname?view=word-pia"/>
  public string? CommandName { get; set; }

  /// <summary>
  /// Gets the command bar control ID associated with the dialog box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialog.commandbarid?view=word-pia"/>
  public int CommandBarId { get; set; }


  #region methods

/// <summary>
  /// Displays the dialog box and returns a value that indicates which button the user chose.
  /// </summary>
  /// <param name="timeOut">The time, in milliseconds, before the dialog box is closed automatically.</param>
  /// <returns>An integer value indicating the user's selection.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialog.show?view=word-pia"/>
  public int Show(object timeOut) { throw new NotImplementedException(); }

  #endregion methods
}
