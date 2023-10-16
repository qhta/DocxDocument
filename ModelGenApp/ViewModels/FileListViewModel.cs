namespace ModelGenApp.ViewModels;

public class FileListViewModel : ViewModel<CompilationFiles>, IEnumerable<FileViewModel>
{
  public FileListViewModel(CompilationFiles model) : base(model)
  {
    Files = new ListViewModel<FileViewModel>();
    CollectionViewSource = new CollectionViewSource<FileViewModel>(Files);
    VisibleItems = CollectionViewSource.GetDefaultView(Files);
    GetData(model);
  }

  public ListViewModel<FileViewModel> Files { get; private set; }


  private CollectionViewSource<FileViewModel> CollectionViewSource;
  /// <summary>
  /// This is the result collection view to be used in DataGrid.
  /// </summary>
  public ICollectionView VisibleItems { get; private set; }

  public void GetData(CompilationFiles compilationFiles)
  {
    Files.Clear();
    foreach (var item in compilationFiles)
    {
      var file = item.Value;
      if (file is CompilationFolder compilationFolder)
        Files.Add(new FolderViewModel(compilationFolder));
      else
        Files.Add(new FileViewModel(file));
    }
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
