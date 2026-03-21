namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents shadow formatting for a shape.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat?view=word-pia"/>
public partial interface ShadowFormat : InteropObject
{
  /// <summary>
  /// The fore color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.forecolor?view=word-pia"/>
  public ColorFormat ForeColor { get; }

  /// <summary>
  /// The obscured.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.obscured?view=word-pia"/>
  public Core.MsoTriState Obscured { get; set; }

  /// <summary>
  /// The offset x.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.offsetx?view=word-pia"/>
  public float OffsetX { get; set; }

  /// <summary>
  /// The offset y.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.offsety?view=word-pia"/>
  public float OffsetY { get; set; }

  /// <summary>
  /// The transparency.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.transparency?view=word-pia"/>
  public float Transparency { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.type?view=word-pia"/>
  public Core.MsoShadowType Type { get; set; }

  /// <summary>
  /// The visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.visible?view=word-pia"/>
  public Core.MsoTriState Visible { get; set; }

  /// <summary>
  /// The style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.style?view=word-pia"/>
  public Core.MsoShadowStyle Style { get; set; }

  /// <summary>
  /// The blur.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.blur?view=word-pia"/>
  public float Blur { get; set; }

  /// <summary>
  /// The size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.size?view=word-pia"/>
  public float Size { get; set; }

  /// <summary>
  /// The rotate with shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.rotatewithshape?view=word-pia"/>
  public Core.MsoTriState RotateWithShape { get; set; }
}
