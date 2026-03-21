namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a built-in dialog box.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialog?view=word-pia"/>
public partial interface Dialog : InteropObject
{
  /// <summary>
  /// The default tab.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialog.defaulttab?view=word-pia"/>
  public WdWordDialogTab DefaultTab { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialog.type?view=word-pia"/>
  public WdWordDialog Type { get; }

  /// <summary>
  /// The command name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialog.commandname?view=word-pia"/>
  public string CommandName { get; }

  /// <summary>
  /// The command bar id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dialog.commandbarid?view=word-pia"/>
  public int CommandBarId { get; }
}
