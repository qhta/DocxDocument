namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a group character object, consisting of a character drawn above or below text, often with the purpose of visually grouping items.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathgroupchar?view=word-pia"/>
public interface OMathGroupChar : InteropObject
{
  /// <summary>
  /// Returns the e.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathgroupchar.e?view=word-pia"/>
  public OMath E { get; }
  /// <summary>
  /// Returns or sets the char.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathgroupchar.char?view=word-pia"/>
  public short Char { get; set; }
  /// <summary>
  /// Returns or sets whether char top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathgroupchar.chartop?view=word-pia"/>
  public bool CharTop { get; set; }
  /// <summary>
  /// Returns or sets whether align top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathgroupchar.aligntop?view=word-pia"/>
  public bool AlignTop { get; set; }

}
