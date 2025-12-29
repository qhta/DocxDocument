namespace DocxEd.Helpers;

/// <summary>
/// Helper class to represent filter for <see cref="DocxEd.TypeInfoViewModel"/>.
/// </summary>
public record TypeInfoViewModelFilter: TypeInfoViewModelFilter<TypeInfoViewModel>
{
  public TypeInfoViewModelFilter(SummaryInfoKind filter, object? value): base(filter, value){ }
}
