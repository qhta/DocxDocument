namespace ModelGenApp.ViewModels;

public class FileViewModel : VisibleViewModel<FileModel>
{
  public FileViewModel(FolderViewModel? parent, FileModel model) : base(parent, model)
  {
    ShowDetailsCommand = new RelayCommand(ShowDetailsExecute, ShowDetailsCanExecute) { Name = "ShowDetailsCommand" };
  }

  public string FullName => ((this.ParentViewModel is FolderViewModel parentFolder) ? parentFolder?.FullName 
    : Path.GetDirectoryName(ProcessOptionsMgr.GetInstance().CodeOutputPath))+ @"\" + Name;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Filename)
  )]
  public string Name => Model?.Filename!;


  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Count)
  )]
  public int? Count { get; protected set; }

  public virtual string Caption => Name;

  public string Title => FullName;


  public string Text
  {
    get { return GetText(); }
    set
    {
      if (_Text != value)
      {
        _Text = value;
        NotifyPropertyChanged(nameof(Text));
      }
    }
  }
  private string _Text = null!;

  public string GetText()
  {
    if (_Text == null)
    {
      try
      {
        using (var reader = File.OpenText(FullName))
        {
          _Text = reader.ReadToEnd();
        }
      }
      catch
      {
        _Text = string.Empty;
      }
    }
    return _Text;
  }

  #region ShowDetailsCommand
  public Command ShowDetailsCommand { get; private set; }

  protected virtual bool ShowDetailsCanExecute()
  {
    return true;
  }


  protected virtual void ShowDetailsExecute()
  {
    WindowsManager.ShowWindow<FileViewWindow>(this);
  }
  #endregion
}
