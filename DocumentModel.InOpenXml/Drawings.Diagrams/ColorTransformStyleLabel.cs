namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Style Label.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorTransformStyleLabel))]
/// <summary>
/// Represents the Color Transform Style Label.
/// </summary>
public class ColorTransformStyleLabel : ModelElement<DXDD.ColorTransformStyleLabel>
{
 /// <summary>
 ///   Name
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.Name))]
 /// <summary>
 /// Name.
 /// </summary>
 public string? Name { get; set; }

 /// <summary>
 ///   Fill Color List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.FillColorList))]
 /// <summary>
 /// Fill Color List.
 /// </summary>
 public FillColorList? FillColorList { get; set; }

 /// <summary>
 ///   Line Color List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.LineColorList))]
 /// <summary>
 /// Line Color List.
 /// </summary>
 public LineColorList? LineColorList { get; set; }

 /// <summary>
 ///   Effect Color List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.EffectColorList))]
 /// <summary>
 /// Effect Color List.
 /// </summary>
 public EffectColorList? EffectColorList { get; set; }

 /// <summary>
 ///   Text Line Color List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.TextLineColorList))]
 /// <summary>
 /// Text Line Color List.
 /// </summary>
 public TextLineColorList? TextLineColorList { get; set; }

 /// <summary>
 ///   Text Fill Color List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.TextFillColorList))]
 /// <summary>
 /// Text Fill Color List.
 /// </summary>
 public TextFillColorList? TextFillColorList { get; set; }

 /// <summary>
 ///   Text Effect Color List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.TextEffectColorList))]
 /// <summary>
 /// Text Effect Color List.
 /// </summary>
 public TextEffectColorList? TextEffectColorList { get; set; }

 /// <summary>
 ///   ExtensionList.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.ExtensionList))]
 /// <summary>
 /// Extension List.
 /// </summary>
 public ExtensionList? ExtensionList { get; set; }
}

