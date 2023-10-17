namespace ModelGenApp.ViewModels;

public class FolderViewModel : FileViewModel
{
  public FolderViewModel(FolderModel model) : base(model)
  {
    Items = new FileListViewModel(model.Items);
    Count = model.Items.Count;
    TotalCount = model.Items.TotalCount;
  }

  public FileListViewModel Items { get; private set; }
  public int TotalCount { get; private set; }

  public override string Caption => Name+$" ({TotalCount})";

}
