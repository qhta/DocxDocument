namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents shadow formatting for a shape.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat?view=word-pia"/>
public interface IShadowFormat : IInteropObject
{
  /// <summary>
  /// Returns or sets a ColorFormat object that represents the foreground color for the shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.forecolor?view=word-pia"/>
  public ColorFormat ForeColor { get; }

  /// <summary>
  /// MsoTrue if the shadow of the specified shape appears filled in and is obscured by the shape, even if the shape
  /// has no fill. MsoFalse if the shadow has no fill and the outline of the shadow is visible through the shape if
  /// the shape has no fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.obscured?view=word-pia"/>
  public Core.TriState Obscured { get; set; }

  /// <summary>
  /// Returns or sets the horizontal offset (in points) of the shadow from the specified shape. A positive value
  /// offsets the shadow to the right of the shape; a negative value offsets it to the left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.offsetx?view=word-pia"/>
  public float OffsetX { get; set; }

  /// <summary>
  /// Returns or sets the vertical offset (in points) of the shadow from the specified shape. A positive value
  /// offsets the shadow below the shape; a negative value offsets it above the shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.offsety?view=word-pia"/>
  public float OffsetY { get; set; }

  /// <summary>
  /// Returns or sets the degree of transparency of the specified fill, shadow, or line as a value between 0.0
  /// (opaque) and 1.0 (clear).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.transparency?view=word-pia"/>
  public float Transparency { get; set; }

  /// <summary>
  /// Returns or sets the shape shadow type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.type?view=word-pia"/>
  public Core.ShadowType Type { get; set; }

  /// <summary>
  /// True if the specified object, or the formatting applied to it, is visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.visible?view=word-pia"/>
  public Core.TriState Visible { get; set; }

  /// <summary>
  /// Returns or sets a ShadowType that represents the type of shadow formatting to apply to a shape. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.style?view=word-pia"/>
  public Core.ShadowStyle Style { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents the blur level for a shadow format. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.blur?view=word-pia"/>
  public float Blur { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents the width of the shadow. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.size?view=word-pia"/>
  public float Size { get; set; }

  /// <summary>
  /// Returns or sets an TriState that represents whether to rotate the shadow when rotating the shape.
  /// Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.rotatewithshape?view=word-pia"/>
  public Core.TriState RotateWithShape { get; set; }


  #region methods

/// <summary>
  /// Increments the shadow's horizontal offset by the specified amount.
  /// </summary>
  /// <param name="Increment">The amount to increment the horizontal offset.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.incrementoffsetx?view=word-pia"/>
  public void IncrementOffsetX(float Increment);

  #endregion methods
}
