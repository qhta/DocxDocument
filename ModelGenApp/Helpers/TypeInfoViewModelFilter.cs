namespace ModelGenApp.Helpers;

/// <summary>
/// Helper class to represent filter for <see cref="ModelGenApp.TypeInfoViewModel"/>.
/// </summary>
public record TypeInfoViewModelFilter: TypeInfoViewModelFilter<TypeInfoViewModel>
{
  public TypeInfoViewModelFilter(TypeInfoKind filter, object? value): base(filter, value){ }
}
