namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies what text effect to use on a WordArt object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresettexteffect?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoPresetTextEffect))]
public enum PresetTextEffect
{
  /// <summary>
  /// Not used.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffectMixed))]
  Mixed = -2,
  /// <summary>
  /// First text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect1))]
  Effect1 = 0,
  /// <summary>
  /// Second text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect2))]
  Effect2 = 1,
  /// <summary>
  /// Third text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect3))]
  Effect3 = 2,
  /// <summary>
  /// Fourth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect4))]
  Effect4 = 3,
  /// <summary>
  /// Fifth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect5))]
  Effect5 = 4,
  /// <summary>
  /// Sixth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect6))]
  Effect6 = 5,
  /// <summary>
  /// Seventh text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect7))]
  Effect7 = 6,
  /// <summary>
  /// Eighth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect8))]
  Effect8 = 7,
  /// <summary>
  /// Ninth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect9))]
  Effect9 = 8,
  /// <summary>
  /// Tenth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect10))]
  Effect10 = 9,
  /// <summary>
  /// Eleventh text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect11))]
  Effect11 = 10,
  /// <summary>
  /// Twelfth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect12))]
  Effect12 = 11,
  /// <summary>
  /// Thirteenth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect13))]
  Effect13 = 12,
  /// <summary>
  /// Fourteenth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect14))]
  Effect14 = 13,
  /// <summary>
  /// Fifteenth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect15))]
  Effect15 = 14,
  /// <summary>
  /// Sixteenth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect16))]
  Effect16 = 15,
  /// <summary>
  /// Seventeenth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect17))]
  Effect17 = 16,
  /// <summary>
  /// Eighteenth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect18))]
  Effect18 = 17,
  /// <summary>
  /// Nineteenth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect19))]
  Effect19 = 18,
  /// <summary>
  /// Twentieth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect20))]
  Effect20 = 19,
  /// <summary>
  /// Twenty-first text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect21))]
  Effect21 = 20,
  /// <summary>
  /// Twenty-second text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect22))]
  Effect22 = 21,
  /// <summary>
  /// Twenty-third text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect23))]
  Effect23 = 22,
  /// <summary>
  /// Twenty-fourth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect24))]
  Effect24 = 23,
  /// <summary>
  /// Twenty-fifth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect25))]
  Effect25 = 24,
  /// <summary>
  /// Twenty-sixth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect26))]
  Effect26 = 25,
  /// <summary>
  /// Twenty-seventh text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect27))]
  Effect27 = 26,
  /// <summary>
  /// Twenty-eighth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect28))]
  Effect28 = 27,
  /// <summary>
  /// Twenty-ninth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect29))]
  Effect29 = 28,
  /// <summary>
  /// Thirtieth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect30))]
  Effect30 = 29,
  /// <summary>
  /// Thirty-first text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect31))]
  Effect31 = 30,
  /// <summary>
  /// Thirty-second text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect32))]
  Effect32 = 31,
  /// <summary>
  /// Thirty-third text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect33))]
  Effect33 = 32,
  /// <summary>
  /// Thirty-fourth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect34))]
  Effect34 = 33,
  /// <summary>
  /// Thirty-fifth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect35))]
  Effect35 = 34,
  /// <summary>
  /// Thirty-sixth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect36))]
  Effect36 = 35,
  /// <summary>
  /// Thirty-seventh text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect37))]
  Effect37 = 36,
  /// <summary>
  /// Thirty-eighth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect38))]
  Effect38 = 37,
  /// <summary>
  /// Thirty-ninth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect39))]
  Effect39 = 38,
  /// <summary>
  /// Fortieth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect40))]
  Effect40 = 39,
  /// <summary>
  /// Forty-first text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect41))]
  Effect41 = 40,
  /// <summary>
  /// Forty-second text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect42))]
  Effect42 = 41,
  /// <summary>
  /// Forty-third text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect43))]
  Effect43 = 42,
  /// <summary>
  /// Forty-fourth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect44))]
  Effect44 = 43,
  /// <summary>
  /// Forty-fifth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect45))]
  Effect45 = 44,
  /// <summary>
  /// Forty-sixth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect46))]
  Effect46 = 45,
  /// <summary>
  /// Forty-seventh text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect47))]
  Effect47 = 46,
  /// <summary>
  /// Forty-eighth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect48))]
  Effect48 = 47,
  /// <summary>
  /// Forty-ninth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect49))]
  Effect49 = 48,
  /// <summary>
  /// Fiftieth text effect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect50))]
  Effect50 = 49
}
