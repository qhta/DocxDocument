using Qhta.MVVM;
using Qhta.WPF.Utils;

namespace DocxEd.ViewModels;

public class ErrorViewModel : VisibleViewModel<CompilationError>
{
  public ErrorViewModel(CompilationError model) : base(model)
  {
  }

  [DataGridColumn(
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.Filename)
  )]
  public string? Filename => Model?.Filename;

  [DataGridColumn(
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.ErrorCode)
  )]
  public string? Code => Model?.Code;

  [DataGridColumn(
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.Description)
  )]
  public string? Description => Model?.Description;
}
