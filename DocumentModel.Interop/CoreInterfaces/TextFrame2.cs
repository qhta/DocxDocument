
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TextFrame2` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2?view=office-pia` for Office interop details.
/// </remarks>
public partial interface TextFrame2: InteropObject
{
  /// <summary>
  /// Gets or sets the `MarginBottom` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.marginbottom?view=office-pia
  /// </remarks>
  public float MarginBottom { get; set; }
  /// <summary>
  /// Gets or sets the `MarginLeft` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.marginleft?view=office-pia
  /// </remarks>
  public float MarginLeft { get; set; }
  /// <summary>
  /// Gets or sets the `MarginRight` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.marginright?view=office-pia
  /// </remarks>
  public float MarginRight { get; set; }
  /// <summary>
  /// Gets or sets the `MarginTop` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.margintop?view=office-pia
  /// </remarks>
  public float MarginTop { get; set; }
  /// <summary>
  /// Gets or sets the `Orientation` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.orientation?view=office-pia
  /// </remarks>
  public MsoTextOrientation Orientation { get; set; }
  /// <summary>
  /// Gets or sets the `HorizontalAnchor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.horizontalanchor?view=office-pia
  /// </remarks>
  public MsoHorizontalAnchor HorizontalAnchor { get; set; }
  /// <summary>
  /// Gets or sets the `VerticalAnchor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.verticalanchor?view=office-pia
  /// </remarks>
  public MsoVerticalAnchor VerticalAnchor { get; set; }
  /// <summary>
  /// Gets or sets the `PathFormat` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.pathformat?view=office-pia
  /// </remarks>
  public MsoPathFormat PathFormat { get; set; }
  /// <summary>
  /// Gets or sets the `WarpFormat` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.warpformat?view=office-pia
  /// </remarks>
  public MsoWarpFormat WarpFormat { get; set; }
  /// <summary>
  /// Gets or sets the `WordArtformat` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.wordartformat?view=office-pia
  /// </remarks>
  public MsoPresetTextEffect WordArtformat { get; set; }
  /// <summary>
  /// Gets or sets the `WordWrap` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.wordwrap?view=office-pia
  /// </remarks>
  public MsoTriState WordWrap { get; set; }
  /// <summary>
  /// Gets or sets the `AutoSize` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.autosize?view=office-pia
  /// </remarks>
  public MsoAutoSize AutoSize { get; set; }
  /// <summary>
  /// Gets the `ThreeD` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.threed?view=office-pia
  /// </remarks>
  public ThreeDFormat ThreeD { get; }
  /// <summary>
  /// Gets the `HasText` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.hastext?view=office-pia
  /// </remarks>
  public MsoTriState HasText { get; }
  /// <summary>
  /// Gets the `TextRange` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.textrange?view=office-pia
  /// </remarks>
  public TextRange2 TextRange { get; }
  /// <summary>
  /// Gets the `Column` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.column?view=office-pia
  /// </remarks>
  public TextColumn2 Column { get; }
  /// <summary>
  /// Gets the `Ruler` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.ruler?view=office-pia
  /// </remarks>
  public Ruler2 Ruler { get; }
  /// <summary>
  /// Gets or sets the `NoTextRotation` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.notextrotation?view=office-pia
  /// </remarks>
  public MsoTriState NoTextRotation { get; set; }
}
