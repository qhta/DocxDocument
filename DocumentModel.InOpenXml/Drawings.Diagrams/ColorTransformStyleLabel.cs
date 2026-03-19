namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Style Label.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorTransformStyleLabel))]
public class ColorTransformStyleLabel : ModelElement<DXDD.ColorTransformStyleLabel>
{
 /// <summary>
 ///   Name
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.Name))]
 public string? Name { get; set; }

 /// <summary>
 ///   Fill Color List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.FillColorList))]
 public FillColorList? FillColorList { get; set; }

 /// <summary>
 ///   Line Color List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.LineColorList))]
 public LineColorList? LineColorList { get; set; }

 /// <summary>
 ///   Effect Color List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.EffectColorList))]
 public EffectColorList? EffectColorList { get; set; }

 /// <summary>
 ///   Text Line Color List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.TextLineColorList))]
 public TextLineColorList? TextLineColorList { get; set; }

 /// <summary>
 ///   Text Fill Color List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.TextFillColorList))]
 public TextFillColorList? TextFillColorList { get; set; }

 /// <summary>
 ///   Text Effect Color List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.TextEffectColorList))]
 public TextEffectColorList? TextEffectColorList { get; set; }

 /// <summary>
 ///   ExtensionList.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformStyleLabel.ExtensionList))]
 public ExtensionList? ExtensionList { get; set; }
}