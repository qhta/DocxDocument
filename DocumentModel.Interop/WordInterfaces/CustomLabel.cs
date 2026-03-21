namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a custom mailing label.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel?view=word-pia"/>
public partial interface CustomLabel : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// The top margin.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.topmargin?view=word-pia"/>
  public float TopMargin { get; set; }

  /// <summary>
  /// The side margin.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.sidemargin?view=word-pia"/>
  public float SideMargin { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// The vertical pitch.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.verticalpitch?view=word-pia"/>
  public float VerticalPitch { get; set; }

  /// <summary>
  /// The horizontal pitch.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.horizontalpitch?view=word-pia"/>
  public float HorizontalPitch { get; set; }

  /// <summary>
  /// The number across.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.numberacross?view=word-pia"/>
  public int NumberAcross { get; set; }

  /// <summary>
  /// The number down.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.numberdown?view=word-pia"/>
  public int NumberDown { get; set; }

  /// <summary>
  /// The dot matrix.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.dotmatrix?view=word-pia"/>
  public bool DotMatrix { get; }

  /// <summary>
  /// The page size.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.pagesize?view=word-pia"/>
  public WdCustomLabelPageSize PageSize { get; set; }

  /// <summary>
  /// The valid.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.valid?view=word-pia"/>
  public bool Valid { get; }
}
