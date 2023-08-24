namespace ModelGenApp.Helpers;

/// <summary>
/// Helper class to represent filter for <see cref="ModelGen.TypeInfo"/>.
/// </summary>
public record TypeInfoFilter
{
  /// <summary>
  /// Initializing constructor. Creates <see cref="Predicate"/> on base of <paramref name="filter"/>.
  /// </summary>
  /// <param name="filter">Must be one of <see cref="SummaryInfoKind"/> enumerations.</param>
  /// <param name="value">
  ///   Must be <see cref="ModelGen.PPS"/> for "AcceptedTypes", "RejectedTypes", and "InvalidTypes" filter.
  ///   Must be string for "TypesWithDuplicateName" filter.
  /// </param>
  /// <exception cref="InvalidOperationException"></exception>
  public TypeInfoFilter(SummaryInfoKind filter, object? value)
  {
    if (value is PPS phaseNum)
    {
      if (filter == SummaryInfoKind.AcceptedTypes)
        Predicate = new Predicate<TypeInfo>(item => item.IsAcceptedAfter(phaseNum));
      else
      if (filter == SummaryInfoKind.RejectedTypes)
        Predicate = new Predicate<TypeInfo>(item => item.IsRejectedAfter(phaseNum));
      else
      if (filter == SummaryInfoKind.InvalidTypes)
        Predicate = new Predicate<TypeInfo>(item => !item.IsValid(phaseNum));
    }
    else
    if (value is string str)
    {
      if (filter == SummaryInfoKind.TypesWithDuplicateName)
        Predicate = new Predicate<TypeInfo>(item => item.GetTargetName() == str);
    }
    else
    {
      if (filter == SummaryInfoKind.RenamedTypes)
        Predicate = new Predicate<TypeInfo>(item => item.IsConverted);
      else
      if (filter == SummaryInfoKind.ConvertedTypes)
        Predicate = new Predicate<TypeInfo>(item => item.IsConverted);
    }
    if (Predicate == null)
        throw new InvalidOperationException($"Can't create TypeInfoFilter with SummaryInfoKind.{filter}");

    Value = value;
  }

  /// <summary>
  /// Predicate to apply in filtering.
  /// </summary>
  public Predicate<TypeInfo> Predicate { get; private set; } = null!;

  /// <summary>
  /// A parameter for predicate.
  /// </summary>
  public object? Value { get; private set; }
}
