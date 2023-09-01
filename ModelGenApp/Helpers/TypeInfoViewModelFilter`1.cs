namespace ModelGenApp.Helpers;

/// <summary>
/// Helper class to represent filter for <see cref="ModelGenApp.TypeInfoViewModel"/>.
/// </summary>
public record TypeInfoViewModelFilter<T>: IFilter<T> where T: TypeInfoViewModel
{
  /// <summary>
  /// Initializing constructor. Creates <see cref="Predicate"/> on base of <paramref name="filter"/>.
  /// </summary>
  /// <param name="filter">Must be one of <see cref="TypeInfoKind"/> enumerations.</param>
  /// <param name="value">
  ///   Must be <see cref="ModelGen.PPS"/> for "AcceptedTypes", "RejectedTypes", and "InvalidTypes" filter.
  ///   Must be string for "TypesWithDuplicateName" filter.
  /// </param>
  /// <exception cref="InvalidOperationException"></exception>
  public TypeInfoViewModelFilter(TypeInfoKind filter, object? value)
  {
    if (value is PPS phaseNum)
    {
      if (filter == TypeInfoKind.AcceptedTypes)
        Predicate = new Predicate<T>(item => item.Model.IsAcceptedAfter(phaseNum));
      else
      if (filter == TypeInfoKind.RejectedTypes)
        Predicate = new Predicate<TypeInfoViewModel>(item => item.Model.IsRejectedAfter(phaseNum));
      else
      if (filter == TypeInfoKind.ProblematicTypes)
        Predicate = new Predicate<TypeInfoViewModel>(item => item.Model.HasProblems(phaseNum));
    }
    else
    if (value is FullTypeName typeName)
    {
      if (filter == TypeInfoKind.TypesWithSameName)
        Predicate = new Predicate<TypeInfoViewModel>(item => item.Model.GetFullName(true, false, false) == typeName);
    }
    else
    {
      if (filter == TypeInfoKind.RenamedTypes)
        Predicate = new Predicate<TypeInfoViewModel>(item => item.Model.IsConverted);
      else
      if (filter == TypeInfoKind.ConvertedTypes)
        Predicate = new Predicate<TypeInfoViewModel>(item => item.Model.IsConverted);
    }
    if (Predicate == null)
        throw new InvalidOperationException($"Can't create TypeInfoViewModelFilter with TypeInfoKind.{filter}");

    Caption = CommonStrings.ResourceManager.GetString(filter.ToString(), CultureInfo.CurrentUICulture) ?? filter.ToString();

    Value = value;
  }
  

  public string Caption { get; set; } = null!;

  /// <summary>
  /// Initializing constructor with known predicate.
  public TypeInfoViewModelFilter(Predicate<TypeInfoViewModel> predicate)
  {
    Predicate = predicate;
  }

  /// <summary>
  /// Predicate to apply in filtering.
  /// </summary>
  public Predicate<T> Predicate { get; private set; } = null!;

  /// <summary>
  /// A parameter for predicate.
  /// </summary>
  public object? Value { get; private set; }

  public Predicate<T> GetPredicate()
  {
    return Predicate;
  }

  public bool Accept(T item)
  {
    return Predicate.Invoke(item);
  }

  Predicate<object> IFilter.GetPredicate()
  {
    return new Predicate<object>(obj => (obj is T item) && Predicate.Invoke(item));
  }

  public bool Accept(object item)
  {
    return ((IFilter)this).GetPredicate().Invoke(item);
  }
}
