namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the line and shape style.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoshapestyleindex?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoShapeStyleIndex")]
public enum ShapeStyleIndex
{
  /// <summary>
  /// Indicates the line and shape style.
  /// </summary>
  [InteropEnumValue("msoShapeStyleMixed")]
  Mixed = -2,
  /// <summary>
  /// No shape style.
  /// </summary>
  [InteropEnumValue("msoShapeStyleNotAPreset")]
  NotAPreset = 0,
  /// <summary>
  /// Shape style 1.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset1")]
  Preset1 = 1,
  /// <summary>
  /// Shape style 2.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset2")]
  Preset2 = 2,
  /// <summary>
  /// Shape style 3.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset3")]
  Preset3 = 3,
  /// <summary>
  /// Shape style 4.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset4")]
  Preset4 = 4,
  /// <summary>
  /// Shape style 5.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset5")]
  Preset5 = 5,
  /// <summary>
  /// Shape style 6.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset6")]
  Preset6 = 6,
  /// <summary>
  /// Shape style 7.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset7")]
  Preset7 = 7,
  /// <summary>
  /// Shape style 8.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset8")]
  Preset8 = 8,
  /// <summary>
  /// Shape style 9.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset9")]
  Preset9 = 9,
  /// <summary>
  /// Shape style 10.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset10")]
  Preset10 = 10,
  /// <summary>
  /// Shape style 11.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset11")]
  Preset11 = 11,
  /// <summary>
  /// Shape style 12.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset12")]
  Preset12 = 12,
  /// <summary>
  /// Shape style 13.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset13")]
  Preset13 = 13,
  /// <summary>
  /// Shape style 14.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset14")]
  Preset14 = 14,
  /// <summary>
  /// Shape style 15.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset15")]
  Preset15 = 15,
  /// <summary>
  /// Shape style 16.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset16")]
  Preset16 = 16,
  /// <summary>
  /// Shape style 17.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset17")]
  Preset17 = 17,
  /// <summary>
  /// Shape style 18.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset18")]
  Preset18 = 18,
  /// <summary>
  /// Shape style 19.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset19")]
  Preset19 = 19,
  /// <summary>
  /// Shape style 20.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset20")]
  Preset20 = 20,
  /// <summary>
  /// Shape style 21.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset21")]
  Preset21 = 21,
  /// <summary>
  /// Shape style 22.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset22")]
  Preset22 = 22,
  /// <summary>
  /// Shape style 23.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset23")]
  Preset23 = 23,
  /// <summary>
  /// Shape style 24.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset24")]
  Preset24 = 24,
  /// <summary>
  /// Shape style 25.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset25")]
  Preset25 = 25,
  /// <summary>
  /// Shape style 26.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset26")]
  Preset26 = 26,
  /// <summary>
  /// Shape style 27.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset27")]
  Preset27 = 27,
  /// <summary>
  /// Shape style 28.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset28")]
  Preset28 = 28,
  /// <summary>
  /// Shape style 29.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset29")]
  Preset29 = 29,
  /// <summary>
  /// Shape style 30.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset30")]
  Preset30 = 30,
  /// <summary>
  /// Shape style 31.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset31")]
  Preset31 = 31,
  /// <summary>
  /// Shape style 32.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset32")]
  Preset32 = 32,
  /// <summary>
  /// Shape style 33.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset33")]
  Preset33 = 33,
  /// <summary>
  /// Shape style 34.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset34")]
  Preset34 = 34,
  /// <summary>
  /// Shape style 35.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset35")]
  Preset35 = 35,
  /// <summary>
  /// Shape style 36.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset36")]
  Preset36 = 36,
  /// <summary>
  /// Shape style 37.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset37")]
  Preset37 = 37,
  /// <summary>
  /// Shape style 38.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset38")]
  Preset38 = 38,
  /// <summary>
  /// Shape style 39.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset39")]
  Preset39 = 39,
  /// <summary>
  /// Shape style 40.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset40")]
  Preset40 = 40,
  /// <summary>
  /// Shape style 41.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset41")]
  Preset41 = 41,
  /// <summary>
  /// Shape style 42.
  /// </summary>
  [InteropEnumValue("msoShapeStylePreset42")]
  Preset42 = 42,
  /// <summary>
  /// Line style 1.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset1")]
  LineStylePreset1 = 10001,
  /// <summary>
  /// Line style 2.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset2")]
  LineStylePreset2 = 10002,
  /// <summary>
  /// Line style 3.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset3")]
  LineStylePreset3 = 10003,
  /// <summary>
  /// Line style 4.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset4")]
  LineStylePreset4 = 10004,
  /// <summary>
  /// Line style 5.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset5")]
  LineStylePreset5 = 10005,
  /// <summary>
  /// Line style 6.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset6")]
  LineStylePreset6 = 10006,
  /// <summary>
  /// Line style 7.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset7")]
  LineStylePreset7 = 10007,
  /// <summary>
  /// Line style 8.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset8")]
  LineStylePreset8 = 10008,
  /// <summary>
  /// Line style 9.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset9")]
  LineStylePreset9 = 10009,
  /// <summary>
  /// Line style 10.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset10")]
  LineStylePreset10 = 10010,
  /// <summary>
  /// Line style 11.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset11")]
  LineStylePreset11 = 10011,
  /// <summary>
  /// Line style 12.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset12")]
  LineStylePreset12 = 10012,
  /// <summary>
  /// Line style 13.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset13")]
  LineStylePreset13 = 10013,
  /// <summary>
  /// Line style 14.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset14")]
  LineStylePreset14 = 10014,
  /// <summary>
  /// Line style 15.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset15")]
  LineStylePreset15 = 10015,
  /// <summary>
  /// Line style 16.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset16")]
  LineStylePreset16 = 10016,
  /// <summary>
  /// Line style 17.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset17")]
  LineStylePreset17 = 10017,
  /// <summary>
  /// Line style 18.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset18")]
  LineStylePreset18 = 10018,
  /// <summary>
  /// Line style 19.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset19")]
  LineStylePreset19 = 10019,
  /// <summary>
  /// Line style 20.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset20")]
  LineStylePreset20 = 10020,
  /// <summary>
  /// Line style 21.
  /// </summary>
  [InteropEnumValue("msoLineStylePreset21")]
  LineStylePreset21 = 10021
}
