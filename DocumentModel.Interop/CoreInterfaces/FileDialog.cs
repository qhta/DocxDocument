using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface FileDialog: InteropObject
{
  FileDialogFilters Filters { get; }
  int FilterIndex { get; set; }
  string Title { get; set; }
  string ButtonName { get; set; }
  bool AllowMultiSelect { get; set; }
  MsoFileDialogView InitialView { get; set; }
  string InitialFileName { get; set; }
  FileDialogSelectedItems SelectedItems { get; }
  MsoFileDialogType DialogType { get; }
  string Item { get; }
  int Show();
  void Execute();
}