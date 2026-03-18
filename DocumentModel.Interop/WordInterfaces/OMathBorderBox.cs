namespace DocumentModel.Interop;

/// <summary>
/// Represents an invisible box around an equation or part of an equation to which you can assign properties that affect the layout or mathematical formatting of the entire box. For example, a box can serve as an operator emulator with or without an alignment point, serve as a like breakpoint, have an associated argument size (argSz), or be grouped so as not to allow line breaks.
/// </summary>
public interface OMathBorderBox : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  public OMath E { get; }
  /// <summary>
  /// The hide top.
  /// </summary>
  public bool HideTop { get; set; }
  /// <summary>
  /// The hide bot.
  /// </summary>
  public bool HideBot { get; set; }
  /// <summary>
  /// The hide left.
  /// </summary>
  public bool HideLeft { get; set; }
  /// <summary>
  /// The hide right.
  /// </summary>
  public bool HideRight { get; set; }
  /// <summary>
  /// The strike h.
  /// </summary>
  public bool StrikeH { get; set; }
  /// <summary>
  /// The strike v.
  /// </summary>
  public bool StrikeV { get; set; }
  /// <summary>
  /// The strike bltr.
  /// </summary>
  public bool StrikeBLTR { get; set; }
  /// <summary>
  /// The strike tlbr.
  /// </summary>
  public bool StrikeTLBR { get; set; }

}
