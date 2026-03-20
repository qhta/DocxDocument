using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface FileDialog: InteropObject
{
  public FileDialogFilters Filters { get; }
  public int FilterIndex { get; set; }
  public string Title { get; set; }
  public string ButtonName { get; set; }
  public bool AllowMultiSelect { get; set; }
  public MsoFileDialogView InitialView { get; set; }
  public string InitialFileName { get; set; }
  public FileDialogSelectedItems SelectedItems { get; }
  public MsoFileDialogType DialogType { get; }
  public string Item { get; }
  public int Show();
  public void Execute();
}
