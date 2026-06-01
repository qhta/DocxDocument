namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a group character object, consisting of a character drawn above or below text, often with the purpose of visually grouping items.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathgroupchar?view=word-pia"/>
public class OMathGroupChar : InteropObject
{
  /// <summary>
  /// Returns the expression associated with the group character.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathgroupchar.e?view=word-pia"/>
  public OMath E { get; }
  /// <summary>
  /// Returns or sets the group character.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathgroupchar.char?view=word-pia"/>
  public short Char { get; set; }
  /// <summary>
  /// Returns or sets whether the group character is placed above the expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathgroupchar.chartop?view=word-pia"/>
  public bool CharTop { get; set; }
  /// <summary>
  /// Returns or sets whether top alignment is used.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathgroupchar.aligntop?view=word-pia"/>
  public bool AlignTop { get; set; }

}
