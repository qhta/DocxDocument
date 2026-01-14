namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the calendar type, corresponding to Microsoft.Office.Interop.Word.WdCalendarType.
/// </summary>
public enum CalendarType
{
  /// <summary>Gregorian calendar.</summary>
  Gregorian = 1,

  /// <summary>Hebrew calendar.</summary>
  Hebrew = 2,

  /// <summary>Hijri (Islamic) calendar.</summary>
  Hijri = 3,

  /// <summary>Japan calendar.</summary>
  Japan = 4,

  /// <summary>Korean calendar.</summary>
  Korea = 5,

  /// <summary>Taiwan calendar.</summary>
  Taiwan = 6,

  /// <summary>Thai calendar.</summary>
  Thai = 7,

  /// <summary>UmAlQura (Saudi Arabia) calendar.</summary>
  UmAlQura = 8
}