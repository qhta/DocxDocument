namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an invisible box around an equation or part of an equation to which you can assign properties that affect the layout or mathematical formatting of the entire box. For example, a box can serve as an operator emulator with or without an alignment point, serve as a like breakpoint, have an associated argument size (argSz), or be grouped so as not to allow line breaks.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox?view=word-pia"/>
public interface IOMathBorderBox : IInteropObject
{
  /// <summary>
  /// Returns the equation contained in the border box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox.e?view=word-pia"/>
  public OMath E { get; }
  /// <summary>
  /// Returns or sets whether the top border is hidden.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox.hidetop?view=word-pia"/>
  public bool HideTop { get; set; }
  /// <summary>
  /// Returns or sets whether the bottom border is hidden.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox.hidebot?view=word-pia"/>
  public bool HideBot { get; set; }
  /// <summary>
  /// Returns or sets whether the left border is hidden.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox.hideleft?view=word-pia"/>
  public bool HideLeft { get; set; }
  /// <summary>
  /// Returns or sets whether the right border is hidden.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox.hideright?view=word-pia"/>
  public bool HideRight { get; set; }
  /// <summary>
  /// Returns or sets whether a horizontal strike-through line is shown.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox.strikeh?view=word-pia"/>
  public bool StrikeH { get; set; }
  /// <summary>
  /// Returns or sets whether a vertical strike-through line is shown.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox.strikev?view=word-pia"/>
  public bool StrikeV { get; set; }
  /// <summary>
  /// Returns or sets whether a diagonal strike-through line from bottom-left to top-right is shown.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox.strikebltr?view=word-pia"/>
  public bool StrikeBLTR { get; set; }
  /// <summary>
  /// Returns or sets whether a diagonal strike-through line from top-left to bottom-right is shown.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathborderbox.striketlbr?view=word-pia"/>
  public bool StrikeTLBR { get; set; }

}
