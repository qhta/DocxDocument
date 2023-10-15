namespace ModelGenApp.ViewModels;

public class ErrorViewModel : VisibleViewModel<CompilationError>

{
  public ErrorViewModel(CompilationError model) : base(model)
  {
  }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Filename)
  )]
  public string? Filename => Model?.Filename;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.ErrorCode)
  )]
  public string? Code => Model?.Code;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Description)
  )]
  public string? Description => Model?.Description;
}
