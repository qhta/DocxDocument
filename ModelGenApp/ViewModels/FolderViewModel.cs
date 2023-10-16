namespace ModelGenApp.ViewModels;

public class FolderViewModel : FileViewModel
{
  public FolderViewModel(CompilationFolder model) : base(model)
  {
    Items = new FileListViewModel(model.Items);
    Count = model.Items.Count;
  }

  public FileListViewModel Items { get; private set; }

  public override string Caption => Name+$" ({Count})";

}
