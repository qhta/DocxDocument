namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a custom mailing label.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel?view=word-pia"/>
public partial interface CustomLabel : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// The top margin.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.topmargin?view=word-pia"/>
  public float TopMargin { get; set; }

  /// <summary>
  /// The side margin.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.sidemargin?view=word-pia"/>
  public float SideMargin { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// The vertical pitch.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.verticalpitch?view=word-pia"/>
  public float VerticalPitch { get; set; }

  /// <summary>
  /// The horizontal pitch.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.horizontalpitch?view=word-pia"/>
  public float HorizontalPitch { get; set; }

  /// <summary>
  /// The number across.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.numberacross?view=word-pia"/>
  public int NumberAcross { get; set; }

  /// <summary>
  /// The number down.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.numberdown?view=word-pia"/>
  public int NumberDown { get; set; }

  /// <summary>
  /// The dot matrix.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.dotmatrix?view=word-pia"/>
  public bool DotMatrix { get; }

  /// <summary>
  /// The page size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.pagesize?view=word-pia"/>
  public WdCustomLabelPageSize PageSize { get; set; }

  /// <summary>
  /// The valid.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.valid?view=word-pia"/>
  public bool Valid { get; }
}
