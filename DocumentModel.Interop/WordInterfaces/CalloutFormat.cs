namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains properties and methods that apply to line callouts.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat?view=word-pia"/>
public partial interface CalloutFormat : InteropObject
{
  /// <summary>
  /// The accent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.accent?view=word-pia"/>
  public Core.MsoTriState Accent { get; set; }

  /// <summary>
  /// The angle.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.angle?view=word-pia"/>
  public Core.MsoCalloutAngleType Angle { get; set; }

  /// <summary>
  /// The auto attach.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.autoattach?view=word-pia"/>
  public Core.MsoTriState AutoAttach { get; set; }

  /// <summary>
  /// The auto length.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.autolength?view=word-pia"/>
  public Core.MsoTriState AutoLength { get; }

  /// <summary>
  /// The border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.border?view=word-pia"/>
  public Core.MsoTriState Border { get; set; }

  /// <summary>
  /// The drop.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.drop?view=word-pia"/>
  public float Drop { get; }

  /// <summary>
  /// The drop type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.droptype?view=word-pia"/>
  public Core.MsoCalloutDropType DropType { get; }

  /// <summary>
  /// The gap.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.gap?view=word-pia"/>
  public float Gap { get; set; }

  /// <summary>
  /// The length.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.length?view=word-pia"/>
  public float Length { get; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.type?view=word-pia"/>
  public Core.MsoCalloutType Type { get; set; }
}
