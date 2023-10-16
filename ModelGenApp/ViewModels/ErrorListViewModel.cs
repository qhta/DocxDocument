namespace ModelGenApp.ViewModels;

public class ErrorListViewModel : ViewModel<CompilationErrors>
{
  public ErrorListViewModel(CompilationErrors model) : base(model)
  {
    Errors = new ListViewModel<ErrorViewModel>();
    CollectionViewSource = new CollectionViewSource<ErrorViewModel>(Errors);
    VisibleItems = CollectionViewSource.GetDefaultView(Errors);
    GetData(model);
  }

  public ListViewModel<ErrorViewModel> Errors { get; private set; }

  private CollectionViewSource<ErrorViewModel> CollectionViewSource;
  /// <summary>
  /// This is the result collection view to be used in DataGrid.
  /// </summary>
  public ICollectionView VisibleItems { get; private set; }

  public void GetData(CompilationErrors compilationErrors)
  {
    Errors.Clear();
    foreach (var error in compilationErrors)
      Errors.Add(new ErrorViewModel(error));
  }

}
