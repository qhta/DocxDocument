namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an invisible box around an equation or part of an equation to which you can apply properties that affect the mathematical or formatting properties, such as line breaks.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbox?view=word-pia"/>
public interface IOMathBox : IModelObject
{
  /// <summary>
  /// Returns the equation contained in the box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbox.e?view=word-pia"/>
  public IOMath E { get; }
  /// <summary>
  /// Returns or sets whether the box acts as an operator emulator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbox.opemu?view=word-pia"/>
  public bool OpEmu { get; set; }
  /// <summary>
  /// Returns or sets whether line breaks are disallowed within the box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbox.nobreak?view=word-pia"/>
  public bool NoBreak { get; set; }
  /// <summary>
  /// Returns or sets whether differential formatting is applied.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbox.diff?view=word-pia"/>
  public bool Diff { get; set; }

}
