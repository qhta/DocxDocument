
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TextFrame2` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2?view=office-pia"/>
public partial interface ITextFrame2: IInteropObject
{
  /// <summary>
  /// Gets or sets the `MarginBottom` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.marginbottom?view=office-pia"/>
  public float MarginBottom { get; set; }
  /// <summary>
  /// Gets or sets the `MarginLeft` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.marginleft?view=office-pia"/>
  public float MarginLeft { get; set; }
  /// <summary>
  /// Gets or sets the `MarginRight` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.marginright?view=office-pia"/>
  public float MarginRight { get; set; }
  /// <summary>
  /// Gets or sets the `MarginTop` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.margintop?view=office-pia"/>
  public float MarginTop { get; set; }
  /// <summary>
  /// Gets or sets the `Orientation` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.orientation?view=office-pia"/>
  public TextOrientation Orientation { get; set; }
  /// <summary>
  /// Gets or sets the `HorizontalAnchor` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.horizontalanchor?view=office-pia"/>
  public HorizontalAnchor HorizontalAnchor { get; set; }
  /// <summary>
  /// Gets or sets the `VerticalAnchor` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.verticalanchor?view=office-pia"/>
  public VerticalAnchor VerticalAnchor { get; set; }
  /// <summary>
  /// Gets or sets the `PathFormat` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.pathformat?view=office-pia"/>
  public PathFormat PathFormat { get; set; }
  /// <summary>
  /// Gets or sets the `WarpFormat` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.warpformat?view=office-pia"/>
  public WarpFormat WarpFormat { get; set; }
  /// <summary>
  /// Gets or sets the `WordArtformat` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.wordartformat?view=office-pia"/>
  public PresetTextEffect WordArtformat { get; set; }
  /// <summary>
  /// Gets or sets the `WordWrap` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.wordwrap?view=office-pia"/>
  public TriState WordWrap { get; set; }
  /// <summary>
  /// Gets or sets the `AutoSize` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.autosize?view=office-pia"/>
  public AutoSize AutoSize { get; set; }
  /// <summary>
  /// Gets the `ThreeD` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.threed?view=office-pia"/>
  public ThreeDFormat ThreeD { get; }
  /// <summary>
  /// Gets the `HasText` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.hastext?view=office-pia"/>
  public TriState HasText { get; }
  /// <summary>
  /// Gets the `TextRange` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.textrange?view=office-pia"/>
  public TextRange2 TextRange { get; }
  /// <summary>
  /// Gets the `Column` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.column?view=office-pia"/>
  public TextColumn2 Column { get; }
  /// <summary>
  /// Gets the `Ruler` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.ruler?view=office-pia"/>
  public Ruler2 Ruler { get; }
  /// <summary>
  /// Gets or sets the `NoTextRotation` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.notextrotation?view=office-pia"/>
  public TriState NoTextRotation { get; set; }
}

