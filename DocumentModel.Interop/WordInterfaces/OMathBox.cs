namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an invisible box around an equation or part of an equation to which you can apply properties that affect the mathematical or formatting properties, such as line breaks.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbox?view=word-pia"/>
public interface OMathBox : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbox.e?view=word-pia"/>
  public OMath E { get; }
  /// <summary>
  /// The op emu.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbox.opemu?view=word-pia"/>
  public bool OpEmu { get; set; }
  /// <summary>
  /// The no break.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbox.nobreak?view=word-pia"/>
  public bool NoBreak { get; set; }
  /// <summary>
  /// The diff.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbox.diff?view=word-pia"/>
  public bool Diff { get; set; }

}
