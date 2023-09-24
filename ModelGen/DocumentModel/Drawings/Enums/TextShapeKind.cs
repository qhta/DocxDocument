namespace DocumentModel.Drawings;


/// <summary>
///   Preset Text Shape Types
/// </summary>
public enum TextShapeKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textNoShape&quot;.
  /// </summary>
  [EnumString("textNoShape")]
  TextNoShape,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textPlain&quot;.
  /// </summary>
  [EnumString("textPlain")]
  TextPlain,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textStop&quot;.
  /// </summary>
  [EnumString("textStop")]
  TextStop,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textTriangle&quot;.
  /// </summary>
  [EnumString("textTriangle")]
  TextTriangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textTriangleInverted&quot;.
  /// </summary>
  [EnumString("textTriangleInverted")]
  TextTriangleInverted,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textChevron&quot;.
  /// </summary>
  [EnumString("textChevron")]
  TextChevron,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textChevronInverted&quot;.
  /// </summary>
  [EnumString("textChevronInverted")]
  TextChevronInverted,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textRingInside&quot;.
  /// </summary>
  [EnumString("textRingInside")]
  TextRingInside,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textRingOutside&quot;.
  /// </summary>
  [EnumString("textRingOutside")]
  TextRingOutside,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textArchUp&quot;.
  /// </summary>
  [EnumString("textArchUp")]
  TextArchUp,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textArchDown&quot;.
  /// </summary>
  [EnumString("textArchDown")]
  TextArchDown,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textCircle&quot;.
  /// </summary>
  [EnumString("textCircle")]
  TextCircle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textButton&quot;.
  /// </summary>
  [EnumString("textButton")]
  TextButton,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textArchUpPour&quot;.
  /// </summary>
  [EnumString("textArchUpPour")]
  TextArchUpPour,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textArchDownPour&quot;.
  /// </summary>
  [EnumString("textArchDownPour")]
  TextArchDownPour,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textCirclePour&quot;.
  /// </summary>
  [EnumString("textCirclePour")]
  TextCirclePour,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textButtonPour&quot;.
  /// </summary>
  [EnumString("textButtonPour")]
  TextButtonPour,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textCurveUp&quot;.
  /// </summary>
  [EnumString("textCurveUp")]
  TextCurveUp,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textCurveDown&quot;.
  /// </summary>
  [EnumString("textCurveDown")]
  TextCurveDown,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textCanUp&quot;.
  /// </summary>
  [EnumString("textCanUp")]
  TextCanUp,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textCanDown&quot;.
  /// </summary>
  [EnumString("textCanDown")]
  TextCanDown,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textWave1&quot;.
  /// </summary>
  [EnumString("textWave1")]
  TextWave1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textWave2&quot;.
  /// </summary>
  [EnumString("textWave2")]
  TextWave2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textDoubleWave1&quot;.
  /// </summary>
  [EnumString("textDoubleWave1")]
  TextDoubleWave1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textWave4&quot;.
  /// </summary>
  [EnumString("textWave4")]
  TextWave4,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textInflate&quot;.
  /// </summary>
  [EnumString("textInflate")]
  TextInflate,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textDeflate&quot;.
  /// </summary>
  [EnumString("textDeflate")]
  TextDeflate,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textInflateBottom&quot;.
  /// </summary>
  [EnumString("textInflateBottom")]
  TextInflateBottom,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textDeflateBottom&quot;.
  /// </summary>
  [EnumString("textDeflateBottom")]
  TextDeflateBottom,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textInflateTop&quot;.
  /// </summary>
  [EnumString("textInflateTop")]
  TextInflateTop,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textDeflateTop&quot;.
  /// </summary>
  [EnumString("textDeflateTop")]
  TextDeflateTop,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textDeflateInflate&quot;.
  /// </summary>
  [EnumString("textDeflateInflate")]
  TextDeflateInflate,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textDeflateInflateDeflate&quot;.
  /// </summary>
  [EnumString("textDeflateInflateDeflate")]
  TextDeflateInflateDeflate,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textFadeRight&quot;.
  /// </summary>
  [EnumString("textFadeRight")]
  TextFadeRight,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textFadeLeft&quot;.
  /// </summary>
  [EnumString("textFadeLeft")]
  TextFadeLeft,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textFadeUp&quot;.
  /// </summary>
  [EnumString("textFadeUp")]
  TextFadeUp,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textFadeDown&quot;.
  /// </summary>
  [EnumString("textFadeDown")]
  TextFadeDown,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textSlantUp&quot;.
  /// </summary>
  [EnumString("textSlantUp")]
  TextSlantUp,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textSlantDown&quot;.
  /// </summary>
  [EnumString("textSlantDown")]
  TextSlantDown,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textCascadeUp&quot;.
  /// </summary>
  [EnumString("textCascadeUp")]
  TextCascadeUp,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textCascadeDown&quot;.
  /// </summary>
  [EnumString("textCascadeDown")]
  TextCascadeDown,
  
}
