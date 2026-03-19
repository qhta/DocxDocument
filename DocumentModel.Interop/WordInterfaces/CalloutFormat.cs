namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains properties and methods that apply to line callouts.
/// </summary>
public partial interface CalloutFormat : InteropObject
{
  /// <summary>
  /// The accent.
  /// </summary>
  public Core.MsoTriState Accent { get; set; }

  /// <summary>
  /// The angle.
  /// </summary>
  public Core.MsoCalloutAngleType Angle { get; set; }

  /// <summary>
  /// The auto attach.
  /// </summary>
  public Core.MsoTriState AutoAttach { get; set; }

  /// <summary>
  /// The auto length.
  /// </summary>
  public Core.MsoTriState AutoLength { get; }

  /// <summary>
  /// The border.
  /// </summary>
  public Core.MsoTriState Border { get; set; }

  /// <summary>
  /// The drop.
  /// </summary>
  public float Drop { get; }

  /// <summary>
  /// The drop type.
  /// </summary>
  public Core.MsoCalloutDropType DropType { get; }

  /// <summary>
  /// The gap.
  /// </summary>
  public float Gap { get; set; }

  /// <summary>
  /// The length.
  /// </summary>
  public float Length { get; }

  /// <summary>
  /// The type.
  /// </summary>
  public Core.MsoCalloutType Type { get; set; }
}
