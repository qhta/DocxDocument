namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a built-in dialog box.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialog?view=word-pia"/>
public partial interface Dialog : InteropObject
{
  /// <summary>
  /// Gets or sets the tab that appears by default when the dialog box is displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialog.defaulttab?view=word-pia"/>
  public WdWordDialogTab DefaultTab { get; set; }

  /// <summary>
  /// Gets the built-in type of the dialog box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialog.type?view=word-pia"/>
  public WdWordDialog Type { get; }

  /// <summary>
  /// Gets the command name associated with the dialog box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialog.commandname?view=word-pia"/>
  public string CommandName { get; }

  /// <summary>
  /// Gets the command bar control ID associated with the dialog box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialog.commandbarid?view=word-pia"/>
  public int CommandBarId { get; }
}
