namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a custom mailing label.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel?view=word-pia"/>
public partial interface ICustomLabel : IModelObject
{
  /// <summary>
  /// Gets the index number of the custom label in the collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Gets or sets the name of the custom label.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.name?view=word-pia"/>
  public string Name { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the top margin of the label, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.topmargin?view=word-pia"/>
  public float TopMargin { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the side margin of the label, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.sidemargin?view=word-pia"/>
  public float SideMargin { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the height of the label, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.height?view=word-pia"/>
  public float Height { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the width of the label, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.width?view=word-pia"/>
  public float Width { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the vertical pitch between labels, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.verticalpitch?view=word-pia"/>
  public float VerticalPitch { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the horizontal pitch between labels, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.horizontalpitch?view=word-pia"/>
  public float HorizontalPitch { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the number of labels across the page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.numberacross?view=word-pia"/>
  public int NumberAcross { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the number of labels down the page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.numberdown?view=word-pia"/>
  public int NumberDown { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets a value indicating whether the custom label is designed for a dot-matrix printer.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.dotmatrix?view=word-pia"/>
  public bool DotMatrix { get; }

  /// <summary>
  /// Gets or sets the page size used by the custom label.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.pagesize?view=word-pia"/>
  public CustomLabelPageSize PageSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets a value indicating whether the custom label definition is valid.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customlabel.valid?view=word-pia"/>
  public bool Valid { get; }
}
