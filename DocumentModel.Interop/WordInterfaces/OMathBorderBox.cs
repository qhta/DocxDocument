namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an invisible box around an equation or part of an equation to which you can assign properties that affect the layout or mathematical formatting of the entire box. For example, a box can serve as an operator emulator with or without an alignment point, serve as a like breakpoint, have an associated argument size (argSz), or be grouped so as not to allow line breaks.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox?view=word-pia"/>
public interface OMathBorderBox : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox.e?view=word-pia"/>
  public OMath E { get; }
  /// <summary>
  /// The hide top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox.hidetop?view=word-pia"/>
  public bool HideTop { get; set; }
  /// <summary>
  /// The hide bot.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox.hidebot?view=word-pia"/>
  public bool HideBot { get; set; }
  /// <summary>
  /// The hide left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox.hideleft?view=word-pia"/>
  public bool HideLeft { get; set; }
  /// <summary>
  /// The hide right.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox.hideright?view=word-pia"/>
  public bool HideRight { get; set; }
  /// <summary>
  /// The strike h.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox.strikeh?view=word-pia"/>
  public bool StrikeH { get; set; }
  /// <summary>
  /// The strike v.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox.strikev?view=word-pia"/>
  public bool StrikeV { get; set; }
  /// <summary>
  /// The strike bltr.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox.strikebltr?view=word-pia"/>
  public bool StrikeBLTR { get; set; }
  /// <summary>
  /// The strike tlbr.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox.striketlbr?view=word-pia"/>
  public bool StrikeTLBR { get; set; }

}
