namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the line and shape style.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoshapestyleindex?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoShapeStyleIndex")]
public enum ShapeStyleIndex
{
  /// <summary>
  /// Indicates the line and shape style.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStyleMixed")]
  Mixed = -2,
  /// <summary>
  /// No shape style.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStyleNotAPreset")]
  NotAPreset = 0,
  /// <summary>
  /// Shape style 1.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset1")]
  Preset1 = 1,
  /// <summary>
  /// Shape style 2.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset2")]
  Preset2 = 2,
  /// <summary>
  /// Shape style 3.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset3")]
  Preset3 = 3,
  /// <summary>
  /// Shape style 4.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset4")]
  Preset4 = 4,
  /// <summary>
  /// Shape style 5.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset5")]
  Preset5 = 5,
  /// <summary>
  /// Shape style 6.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset6")]
  Preset6 = 6,
  /// <summary>
  /// Shape style 7.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset7")]
  Preset7 = 7,
  /// <summary>
  /// Shape style 8.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset8")]
  Preset8 = 8,
  /// <summary>
  /// Shape style 9.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset9")]
  Preset9 = 9,
  /// <summary>
  /// Shape style 10.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset10")]
  Preset10 = 10,
  /// <summary>
  /// Shape style 11.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset11")]
  Preset11 = 11,
  /// <summary>
  /// Shape style 12.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset12")]
  Preset12 = 12,
  /// <summary>
  /// Shape style 13.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset13")]
  Preset13 = 13,
  /// <summary>
  /// Shape style 14.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset14")]
  Preset14 = 14,
  /// <summary>
  /// Shape style 15.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset15")]
  Preset15 = 15,
  /// <summary>
  /// Shape style 16.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset16")]
  Preset16 = 16,
  /// <summary>
  /// Shape style 17.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset17")]
  Preset17 = 17,
  /// <summary>
  /// Shape style 18.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset18")]
  Preset18 = 18,
  /// <summary>
  /// Shape style 19.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset19")]
  Preset19 = 19,
  /// <summary>
  /// Shape style 20.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset20")]
  Preset20 = 20,
  /// <summary>
  /// Shape style 21.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset21")]
  Preset21 = 21,
  /// <summary>
  /// Shape style 22.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset22")]
  Preset22 = 22,
  /// <summary>
  /// Shape style 23.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset23")]
  Preset23 = 23,
  /// <summary>
  /// Shape style 24.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset24")]
  Preset24 = 24,
  /// <summary>
  /// Shape style 25.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset25")]
  Preset25 = 25,
  /// <summary>
  /// Shape style 26.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset26")]
  Preset26 = 26,
  /// <summary>
  /// Shape style 27.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset27")]
  Preset27 = 27,
  /// <summary>
  /// Shape style 28.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset28")]
  Preset28 = 28,
  /// <summary>
  /// Shape style 29.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset29")]
  Preset29 = 29,
  /// <summary>
  /// Shape style 30.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset30")]
  Preset30 = 30,
  /// <summary>
  /// Shape style 31.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset31")]
  Preset31 = 31,
  /// <summary>
  /// Shape style 32.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset32")]
  Preset32 = 32,
  /// <summary>
  /// Shape style 33.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset33")]
  Preset33 = 33,
  /// <summary>
  /// Shape style 34.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset34")]
  Preset34 = 34,
  /// <summary>
  /// Shape style 35.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset35")]
  Preset35 = 35,
  /// <summary>
  /// Shape style 36.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset36")]
  Preset36 = 36,
  /// <summary>
  /// Shape style 37.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset37")]
  Preset37 = 37,
  /// <summary>
  /// Shape style 38.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset38")]
  Preset38 = 38,
  /// <summary>
  /// Shape style 39.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset39")]
  Preset39 = 39,
  /// <summary>
  /// Shape style 40.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset40")]
  Preset40 = 40,
  /// <summary>
  /// Shape style 41.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset41")]
  Preset41 = 41,
  /// <summary>
  /// Shape style 42.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStylePreset42")]
  Preset42 = 42,
  /// <summary>
  /// Line style 1.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset1")]
  LineStylePreset1 = 10001,
  /// <summary>
  /// Line style 2.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset2")]
  LineStylePreset2 = 10002,
  /// <summary>
  /// Line style 3.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset3")]
  LineStylePreset3 = 10003,
  /// <summary>
  /// Line style 4.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset4")]
  LineStylePreset4 = 10004,
  /// <summary>
  /// Line style 5.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset5")]
  LineStylePreset5 = 10005,
  /// <summary>
  /// Line style 6.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset6")]
  LineStylePreset6 = 10006,
  /// <summary>
  /// Line style 7.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset7")]
  LineStylePreset7 = 10007,
  /// <summary>
  /// Line style 8.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset8")]
  LineStylePreset8 = 10008,
  /// <summary>
  /// Line style 9.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset9")]
  LineStylePreset9 = 10009,
  /// <summary>
  /// Line style 10.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset10")]
  LineStylePreset10 = 10010,
  /// <summary>
  /// Line style 11.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset11")]
  LineStylePreset11 = 10011,
  /// <summary>
  /// Line style 12.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset12")]
  LineStylePreset12 = 10012,
  /// <summary>
  /// Line style 13.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset13")]
  LineStylePreset13 = 10013,
  /// <summary>
  /// Line style 14.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset14")]
  LineStylePreset14 = 10014,
  /// <summary>
  /// Line style 15.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset15")]
  LineStylePreset15 = 10015,
  /// <summary>
  /// Line style 16.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset16")]
  LineStylePreset16 = 10016,
  /// <summary>
  /// Line style 17.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset17")]
  LineStylePreset17 = 10017,
  /// <summary>
  /// Line style 18.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset18")]
  LineStylePreset18 = 10018,
  /// <summary>
  /// Line style 19.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset19")]
  LineStylePreset19 = 10019,
  /// <summary>
  /// Line style 20.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset20")]
  LineStylePreset20 = 10020,
  /// <summary>
  /// Line style 21.
  /// </summary>
  [OfficeInteropEnumValue("msoLineStylePreset21")]
  LineStylePreset21 = 10021
}
