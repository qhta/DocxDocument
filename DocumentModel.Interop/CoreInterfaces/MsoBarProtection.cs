namespace DocumentModel.Interop.Core;

public enum MsoBarProtection
{
  msoBarNoProtection = 0,
  msoBarNoCustomize = 1,
  msoBarNoResize = 2,
  msoBarNoMove = 4,
  msoBarNoChangeVisible = 8,
  msoBarNoChangeDock = 0x10,
  msoBarNoVerticalDock = 0x20,
  msoBarNoHorizontalDock = 0x40
}