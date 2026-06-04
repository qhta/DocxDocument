namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies the shading pattern options for graphical elements in WordprocessingML drawings.
/// This enumeration provides values for various fill and pattern styles, supporting advanced visual effects and background fills for shapes, tables, and other graphical content within the document.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues))]
public enum ShadingPattern
{
  /// <summary>
  /// No pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Nil))]
  Nil,
  /// <summary>
  /// No pattern (clear fill).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Clear))]
  Clear,
  /// <summary>
  /// 100% fill pattern (solid fill).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Solid))]
  Solid,
  /// <summary>
  /// Horizontal stripe pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.HorizontalStripe))]
  HorizontalStripe,
  /// <summary>
  /// Vertical stripe pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.VerticalStripe))]
  VerticalStripe,
  /// <summary>
  /// Reverse diagonal stripe pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.ReverseDiagonalStripe))]
  ReverseDiagonalStripe,
  /// <summary>
  /// Diagonal stripe pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.DiagonalStripe))]
  DiagonalStripe,
  /// <summary>
  /// Horizontal cross pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.HorizontalCross))]
  HorizontalCross,
  /// <summary>
  /// Diagonal cross pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.DiagonalCross))]
  DiagonalCross,
  /// <summary>
  /// Thin horizontal stripe pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.ThinHorizontalStripe))]
  ThinHorizontalStripe,
  /// <summary>
  /// Thin vertical stripe pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.ThinVerticalStripe))]
  ThinVerticalStripe,
  /// <summary>
  /// Thin reverse diagonal stripe pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.ThinReverseDiagonalStripe))]
  ThinReverseDiagonalStripe,
  /// <summary>
  /// Thin diagonal stripe pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.ThinDiagonalStripe))]
  ThinDiagonalStripe,
  /// <summary>
  /// Thin horizontal cross pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.ThinHorizontalCross))]
  ThinHorizontalCross,
  /// <summary>
  /// Thin diagonal cross pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.ThinDiagonalCross))]
  ThinDiagonalCross,
  /// <summary>
  /// 5% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent5))]
  Percent5,
  /// <summary>
  /// 10% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent10))]
  Percent10,
  /// <summary>
  /// 12.5% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent12))]
  Percent12,
  /// <summary>
  /// 15% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent15))]
  Percent15,
  /// <summary>
  /// 20% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent20))]
  Percent20,
  /// <summary>
  /// 25% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent25))]
  Percent25,
  /// <summary>
  /// 30% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent30))]
  Percent30,
  /// <summary>
  /// 35% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent35))]
  Percent35,
  /// <summary>
  /// 37.5% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent37))]
  Percent37,
  /// <summary>
  /// 40% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent40))]
  Percent40,
  /// <summary>
  /// 45% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent45))]
  Percent45,
  /// <summary>
  /// 50% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent50))]
  Percent50,
  /// <summary>
  /// 55% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent55))]
  Percent55,
  /// <summary>
  /// 60% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent60))]
  Percent60,
  /// <summary>
  /// 62.5% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent62))]
  Percent62,
  /// <summary>
  /// 65% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent65))]
  Percent65,
  /// <summary>
  /// 70% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent70))]
  Percent70,
  /// <summary>
  /// 75% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent75))]
  Percent75,
  /// <summary>
  /// 80% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent80))]
  Percent80,
  /// <summary>
  /// 85% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent85))]
  Percent85,
  /// <summary>
  /// 87.5% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent87))]
  Percent87,
  /// <summary>
  /// 90% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent90))]
  Percent90,
  /// <summary>
  /// 95% fill pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues.Percent95))]
  Percent95
}