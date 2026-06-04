namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies what text effect to use on a WordArt object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresettexteffect?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoPresetTextEffect")]
public enum PresetTextEffect
{
  /// <summary>
  /// Not used.
  /// </summary>
  [InteropEnumValue("msoTextEffectMixed")]
  Mixed = -2,
  /// <summary>
  /// First text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect1")]
  Effect1 = 0,
  /// <summary>
  /// Second text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect2")]
  Effect2 = 1,
  /// <summary>
  /// Third text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect3")]
  Effect3 = 2,
  /// <summary>
  /// Fourth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect4")]
  Effect4 = 3,
  /// <summary>
  /// Fifth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect5")]
  Effect5 = 4,
  /// <summary>
  /// Sixth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect6")]
  Effect6 = 5,
  /// <summary>
  /// Seventh text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect7")]
  Effect7 = 6,
  /// <summary>
  /// Eighth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect8")]
  Effect8 = 7,
  /// <summary>
  /// Ninth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect9")]
  Effect9 = 8,
  /// <summary>
  /// Tenth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect10")]
  Effect10 = 9,
  /// <summary>
  /// Eleventh text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect11")]
  Effect11 = 10,
  /// <summary>
  /// Twelfth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect12")]
  Effect12 = 11,
  /// <summary>
  /// Thirteenth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect13")]
  Effect13 = 12,
  /// <summary>
  /// Fourteenth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect14")]
  Effect14 = 13,
  /// <summary>
  /// Fifteenth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect15")]
  Effect15 = 14,
  /// <summary>
  /// Sixteenth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect16")]
  Effect16 = 15,
  /// <summary>
  /// Seventeenth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect17")]
  Effect17 = 16,
  /// <summary>
  /// Eighteenth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect18")]
  Effect18 = 17,
  /// <summary>
  /// Nineteenth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect19")]
  Effect19 = 18,
  /// <summary>
  /// Twentieth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect20")]
  Effect20 = 19,
  /// <summary>
  /// Twenty-first text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect21")]
  Effect21 = 20,
  /// <summary>
  /// Twenty-second text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect22")]
  Effect22 = 21,
  /// <summary>
  /// Twenty-third text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect23")]
  Effect23 = 22,
  /// <summary>
  /// Twenty-fourth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect24")]
  Effect24 = 23,
  /// <summary>
  /// Twenty-fifth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect25")]
  Effect25 = 24,
  /// <summary>
  /// Twenty-sixth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect26")]
  Effect26 = 25,
  /// <summary>
  /// Twenty-seventh text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect27")]
  Effect27 = 26,
  /// <summary>
  /// Twenty-eighth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect28")]
  Effect28 = 27,
  /// <summary>
  /// Twenty-ninth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect29")]
  Effect29 = 28,
  /// <summary>
  /// Thirtieth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect30")]
  Effect30 = 29,
  /// <summary>
  /// Thirty-first text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect31")]
  Effect31 = 30,
  /// <summary>
  /// Thirty-second text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect32")]
  Effect32 = 31,
  /// <summary>
  /// Thirty-third text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect33")]
  Effect33 = 32,
  /// <summary>
  /// Thirty-fourth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect34")]
  Effect34 = 33,
  /// <summary>
  /// Thirty-fifth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect35")]
  Effect35 = 34,
  /// <summary>
  /// Thirty-sixth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect36")]
  Effect36 = 35,
  /// <summary>
  /// Thirty-seventh text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect37")]
  Effect37 = 36,
  /// <summary>
  /// Thirty-eighth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect38")]
  Effect38 = 37,
  /// <summary>
  /// Thirty-ninth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect39")]
  Effect39 = 38,
  /// <summary>
  /// Fortieth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect40")]
  Effect40 = 39,
  /// <summary>
  /// Forty-first text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect41")]
  Effect41 = 40,
  /// <summary>
  /// Forty-second text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect42")]
  Effect42 = 41,
  /// <summary>
  /// Forty-third text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect43")]
  Effect43 = 42,
  /// <summary>
  /// Forty-fourth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect44")]
  Effect44 = 43,
  /// <summary>
  /// Forty-fifth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect45")]
  Effect45 = 44,
  /// <summary>
  /// Forty-sixth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect46")]
  Effect46 = 45,
  /// <summary>
  /// Forty-seventh text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect47")]
  Effect47 = 46,
  /// <summary>
  /// Forty-eighth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect48")]
  Effect48 = 47,
  /// <summary>
  /// Forty-ninth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect49")]
  Effect49 = 48,
  /// <summary>
  /// Fiftieth text effect.
  /// </summary>
  [InteropEnumValue("msoTextEffect50")]
  Effect50 = 49
}
