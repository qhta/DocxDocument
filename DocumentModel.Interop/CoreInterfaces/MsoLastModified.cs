using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
public enum MsoLastModified
{
  msoLastModifiedYesterday = 1,
  msoLastModifiedToday,
  msoLastModifiedLastWeek,
  msoLastModifiedThisWeek,
  msoLastModifiedLastMonth,
  msoLastModifiedThisMonth,
  msoLastModifiedAnyTime
}