namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents shadow formatting for a shape.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat?view=word-pia"/>
public partial interface ShadowFormat : InteropObject
{
  /// <summary>
  /// Returns the fore color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.forecolor?view=word-pia"/>
  public ColorFormat ForeColor { get; }

  /// <summary>
  /// Returns or sets whether obscured.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.obscured?view=word-pia"/>
  public Core.MsoTriState Obscured { get; set; }

  /// <summary>
  /// Returns or sets the offset x.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.offsetx?view=word-pia"/>
  public float OffsetX { get; set; }

  /// <summary>
  /// Returns or sets the offset y.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.offsety?view=word-pia"/>
  public float OffsetY { get; set; }

  /// <summary>
  /// Returns or sets the transparency.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.transparency?view=word-pia"/>
  public float Transparency { get; set; }

  /// <summary>
  /// Returns or sets the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.type?view=word-pia"/>
  public Core.MsoShadowType Type { get; set; }

  /// <summary>
  /// Returns or sets whether visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.visible?view=word-pia"/>
  public Core.MsoTriState Visible { get; set; }

  /// <summary>
  /// Returns or sets the style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.style?view=word-pia"/>
  public Core.MsoShadowStyle Style { get; set; }

  /// <summary>
  /// Returns or sets the blur.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.blur?view=word-pia"/>
  public float Blur { get; set; }

  /// <summary>
  /// Returns or sets the size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.size?view=word-pia"/>
  public float Size { get; set; }

  /// <summary>
  /// Returns or sets whether rotate with shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.rotatewithshape?view=word-pia"/>
  public Core.MsoTriState RotateWithShape { get; set; }
}
