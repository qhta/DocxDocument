namespace ModelGenApp.ViewModels;

public class FileViewModel : VisibleViewModel<FileModel>
{
  public FileViewModel(FileModel model) : base(model)
  {
  }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Filename)
  )]
  public string Name => Model?.Filename!;


  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Count)
  )]
  public int? Count { get; protected set; }

  public virtual string Caption => Name;
}
