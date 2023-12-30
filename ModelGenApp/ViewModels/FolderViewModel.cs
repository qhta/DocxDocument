namespace ModelGenApp.ViewModels;

public class FolderViewModel : FileViewModel
{
  public FolderViewModel(FolderViewModel? parent, FolderModel model) : base(parent, model)
  {
    Items = new FileListViewModel(this, model.Items);
    Count = model.Items.Count;
    TotalCount = model.Items.TotalCount;
  }

  public FileListViewModel Items { [DebuggerStepThrough] get; private set; }
  public int TotalCount { [DebuggerStepThrough] get; private set; }

  public override string Caption => Name+$" ({TotalCount})";

}
