namespace ModelGenApp.ViewModels;

public class FileListViewModel : ViewModel<FilesList>, IEnumerable<FileViewModel>
{
  public FileListViewModel(FilesList model) : this(null, model) { }

  public FileListViewModel(FolderViewModel? parent, FilesList model) : base(model)
  {
    ParentFolder = parent;
    Files = new ListViewModel<FileViewModel>();
    CollectionViewSource = new CollectionViewSource<FileViewModel>(Files);
    VisibleItems = CollectionViewSource.GetDefaultView(Files);
    GetData(model);
  }

  public FolderViewModel? ParentFolder { get; set; }

  public ListViewModel<FileViewModel> Files { get; private set; }


  private CollectionViewSource<FileViewModel> CollectionViewSource;
  /// <summary>
  /// This is the result collection view to be used in DataGrid.
  /// </summary>
  public ICollectionView VisibleItems { get; private set; }

  public void GetData(FilesList compilationFiles)
  {
    Files.Clear();
    foreach (var folder in compilationFiles.Where(item => item.Value is FolderModel).OrderBy(item => item.Key).Select(item => item.Value).Cast<FolderModel>())
      Files.Add(new FolderViewModel(ParentFolder, folder));
    foreach (var file in compilationFiles.Where(item => !(item.Value is FolderModel)).OrderBy(item => item.Key).Select(item => item.Value))
      Files.Add(new FileViewModel(ParentFolder, file));
  }

  public IEnumerator<FileViewModel> GetEnumerator()
  {
    return ((IEnumerable<FileViewModel>)Files).GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return ((IEnumerable)Files).GetEnumerator();
  }
}
