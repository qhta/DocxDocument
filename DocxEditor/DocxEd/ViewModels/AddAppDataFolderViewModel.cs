namespace DocxEd.ViewModels;

/// <summary>
/// View model for <see cref="AddAppDataFolderDialog"/>
/// </summary>
public class AddAppDataFolderViewModel: ViewModel
{
  /// <summary>
  /// Dialog window title.
  /// </summary>
  public string Title => CommonStrings.AddNewAppDataFolder;

  /// <summary>
  /// Name of the subfolder to add to AppData folder.
  /// </summary>
  public string? NewFolderName
  {
    [DebuggerStepThrough] get { return _NewFolderName; }
    set
    {
      if (_NewFolderName != value)
      {
        _NewFolderName = value;
        NotifyPropertyChanged(nameof(NewFolderName));
      }
    }
  }
  private string? _NewFolderName;

  /// <summary>
  /// Subfolders existing in AppData folder.
  /// </summary>
  public string[] ExistingFolders
  {
   [DebuggerStepThrough] get { return _ExistingFolders; }
    set
    {
      if (_ExistingFolders != value)
      {
        _ExistingFolders = value;
        NotifyPropertyChanged(nameof(ExistingFolders));
      }
    }
  }
  private string[] _ExistingFolders = new string[0];

  /// <summary>
  /// True if content of the <see cref="FolderToCopy"/> should be copied.
  /// </summary>
  public bool CopyContent
  {
   [DebuggerStepThrough] get { return _CopyContent; }
    set
    {
      if (_CopyContent != value)
      {
        _CopyContent = value;
        NotifyPropertyChanged(nameof(CopyContent));
      }
    }
  }
  private bool _CopyContent;

  /// <summary>
  /// Source folder to copy to new folder.
  /// </summary>
  public string? FolderToCopy
  {
   [DebuggerStepThrough] get { return _FolderToCopy; }
    set
    {
      if (_FolderToCopy != value)
      {
        _FolderToCopy = value;
        NotifyPropertyChanged(nameof(FolderToCopy));
      }
    }
  }
  private string? _FolderToCopy;
}
