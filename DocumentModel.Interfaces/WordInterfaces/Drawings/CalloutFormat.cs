namespace DocumentModel.Wordprocessing;

/// <summary>
/// Contains properties and methods that apply to line callouts.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat?view=word-pia"/>
public partial interface CalloutFormat : InteropObject
{
  /// <summary>
  /// Gets or sets a value indicating whether the callout line has an accent bar.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.accent?view=word-pia"/>
  public TriState Accent { get; set; }

  /// <summary>
  /// Gets or sets the angle type of the callout line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.angle?view=word-pia"/>
  public Drw.CalloutAngleType Angle { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the callout automatically attaches to points on the shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.autoattach?view=word-pia"/>
  public TriState AutoAttach { get; set; }

  /// <summary>
  /// Gets a value indicating whether the callout length is adjusted automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.autolength?view=word-pia"/>
  public TriState AutoLength { get; }

  /// <summary>
  /// Gets or sets a value indicating whether the callout has a border around the text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.border?view=word-pia"/>
  public TriState Border { get; set; }

  /// <summary>
  /// Gets the vertical distance, in points, between the callout text and the callout line anchor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.drop?view=word-pia"/>
  public float Drop { get; }

  /// <summary>
  /// Gets the drop type of the callout line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.droptype?view=word-pia"/>
  public Drw.CalloutDropType DropType { get; }

  /// <summary>
  /// Gets or sets the distance, in points, between the callout line and the callout text box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.gap?view=word-pia"/>
  public float Gap { get; set; }

  /// <summary>
  /// Gets the length, in points, of the callout line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.length?view=word-pia"/>
  public float Length { get; }

  /// <summary>
  /// Gets or sets the callout type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.calloutformat.type?view=word-pia"/>
  public Drw.CalloutType Type { get; set; }
}
