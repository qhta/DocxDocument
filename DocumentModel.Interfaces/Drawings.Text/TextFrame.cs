
using DocumentModel.Wordprocessing;

namespace DocumentModel.Drawings.Text;

/// <summary>
/// Represents the `TextFrame2` interface.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2?view=office-pia"/>
public partial interface ITextFrame : IModelObject
{
  /// <summary>
  /// Gets or sets the `MarginBottom` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.marginbottom?view=office-pia"/>
  public float MarginBottom { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `MarginLeft` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.marginleft?view=office-pia"/>
  public float MarginLeft { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `MarginRight` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.marginright?view=office-pia"/>
  public float MarginRight { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `MarginTop` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.margintop?view=office-pia"/>
  public float MarginTop { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Orientation` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.orientation?view=office-pia"/>
  public TextOrientation Orientation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `HorizontalAnchor` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.horizontalanchor?view=office-pia"/>
  public HorizontalAnchor HorizontalAnchor { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `VerticalAnchor` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.verticalanchor?view=office-pia"/>
  public VerticalAnchor VerticalAnchor { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `PathFormat` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.pathformat?view=office-pia"/>
  public Drawings.PathFormat PathFormat { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `WarpFormat` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.warpformat?view=office-pia"/>
  public Drawings.WarpFormat WarpFormat { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `WordArtformat` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.wordartformat?view=office-pia"/>
  public Drawings.PresetTextEffect WordArtformat { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `WordWrap` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.wordwrap?view=office-pia"/>
  public TriState WordWrap { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `AutoSize` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.autosize?view=office-pia"/>
  public AutoSize AutoSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the `ThreeD` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.threed?view=office-pia"/>
  public IThreeDFormat ThreeD { get; }
  /// <summary>
  /// Gets the `HasText` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.hastext?view=office-pia"/>
  public TriState HasText { get; }
  /// <summary>
  /// Gets the `TextRange` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.textrange?view=office-pia"/>
  public ITextRange TextRange { get; }
  /// <summary>
  /// Gets the `Column` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.column?view=office-pia"/>
  public ITextColumn Column { get; }
  /// <summary>
  /// Gets the `Ruler` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.ruler?view=office-pia"/>
  public IRuler Ruler { get; }
  /// <summary>
  /// Gets or sets the `NoTextRotation` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.notextrotation?view=office-pia"/>
  public TriState NoTextRotation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

