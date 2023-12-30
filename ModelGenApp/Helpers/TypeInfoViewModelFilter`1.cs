namespace ModelGenApp.Helpers;

/// <summary>
/// Helper class to represent filter for <see cref="ModelGenApp.TypeInfoViewModel"/>.
/// </summary>
public record TypeInfoViewModelFilter<T> : IFilter where T : TypeInfoViewModel
{


  public static bool CanFilter(SummaryInfoKind filter)
  {
    if (filter == SummaryInfoKind.AcceptedTypes)
      return true;
    if (filter == SummaryInfoKind.RejectedTypes)
      return true;
    if (filter == SummaryInfoKind.InvalidTypes)
      return true;
    if (filter == SummaryInfoKind.TypesWithSameName)
      return true;
    if (filter == SummaryInfoKind.RenamedTypes)
      return true;
    if (filter == SummaryInfoKind.ConvertedTypes)
      return true;
    if (filter == SummaryInfoKind.TargetTypes)
      return true;
    if (filter == SummaryInfoKind.TypesWithoutDescription)
      return true;
    if (filter == SummaryInfoKind.TypesWithMeaninglessDescription)
      return true;
    if (filter == SummaryInfoKind.FixedTypes)
      return true;
    return false;
  }

  /// <summary>
  /// Initializing constructor. Creates <see cref="Predicate"/> on base of <paramref name="filter"/>.
  /// </summary>
  /// <param name="filter">Must be one of <see cref="SummaryInfoKind"/> enumerations.</param>
  /// <param name="value">
  ///   Must be <see cref="ModelGen.PPS"/> for "AcceptedTypes", "RejectedTypes", and "InvalidTypes" filter.
  ///   Must be string for "TypesWithDuplicateName" filter.
  /// </param>
  /// <exception cref="InvalidOperationException"></exception>
  public TypeInfoViewModelFilter(SummaryInfoKind filter, object? value)
  {
    //if (filter == TypeInfoKind.TargetTypes)
    //  Debug.Assert(true);
    if (value is PPS phaseNum)
    {
      if (filter == SummaryInfoKind.AcceptedTypes)
        Predicate = new Predicate<T>(item => item.Model.IsAcceptedAfter(phaseNum));
      else
      if (filter == SummaryInfoKind.RejectedTypes)
        Predicate = new Predicate<T>(item => item.Model.IsRejectedAfter(phaseNum));
      else
      if (filter == SummaryInfoKind.InvalidTypes)
        Predicate = new Predicate<T>(item => item.Model.IsInvalid(phaseNum));
      else
      if (filter == SummaryInfoKind.TypesWithoutDescription)
        Predicate = new Predicate<T>(item => String.IsNullOrEmpty(item.Model.Description));
      else
      if (filter == SummaryInfoKind.TypesWithMeaninglessDescription)
        Predicate = new Predicate<T>(item => item.Model.IsInvalid(phaseNum) && item.Model.Description != null && item.Model.Description.Trim() != "");
      else
      if (filter == SummaryInfoKind.RenamedTypes)
        Predicate = new Predicate<T>(item => item.Model.NewName != null);
      else
      if (filter == SummaryInfoKind.TypesWithSameName)
        Predicate = new Predicate<T>(item => item.Model.HasError(PPS.Rename, ErrorCode.DuplicateName));
      else
      if (filter == SummaryInfoKind.ConvertedTypes)
        Predicate = new Predicate<T>(item => item.Model.ConversionTarget!= null);
      else
      if (filter == SummaryInfoKind.FixedTypes)
        Predicate = new Predicate<T>(item => item.Model.IsFixed(phaseNum));
    }
    else
    if (value is FullTypeName typeName)
    {
      if (filter == SummaryInfoKind.TypesWithSameName)
        Predicate = new Predicate<T>(item => item.Model.GetFullName(true, false, false) == typeName);
    }
    else
    {
      if (filter == SummaryInfoKind.RenamedTypes)
        Predicate = new Predicate<T>(item => item.Model.TargetName!=null);
      else
      if (filter == SummaryInfoKind.ConvertedTypes)
        Predicate = new Predicate<T>(item => item.Model.ConversionTarget!=null);
    }
    if (Predicate == null)
      throw new InvalidOperationException($"Can't create TypeInfoViewModelFilter with TypeInfoKind.{filter}");

    Caption = CommonStrings.ResourceManager.GetString(filter.ToString(), CultureInfo.CurrentUICulture) ?? filter.ToString();

    Value = value;
  }

  private bool HasDuplicateNames(TypeInfo typeInfo)
  {
    if (typeInfo.IsAcceptedAfter(PPS.Rename) && !typeInfo.IsConstructedGenericType)
    {
      var targetName = typeInfo.TargetName;
      var sameNameTypes = TypeManager.AllTypes.Where(item => item.IsAcceptedAfter(PPS.Rename) && !item.IsConstructedGenericType)
        .Where(item => item.TargetNamespace == typeInfo.TargetNamespace)
        .Where(item => item.GetFullName(true, false, false) == targetName).ToList();
      if (sameNameTypes.Count()>1)
        return true;
    }
    return false;
  }

  public string Caption { [DebuggerStepThrough] get; set; } = null!;

  /// <summary>
  /// Initializing constructor with known predicate.
  public TypeInfoViewModelFilter(Predicate<TypeInfoViewModel> predicate)
  {
    Predicate = predicate;
  }

  /// <summary>
  /// Predicate to apply in filtering.
  /// </summary>
  public Predicate<T> Predicate { [DebuggerStepThrough] get; private set; } = null!;

  /// <summary>
  /// A parameter for predicate.
  /// </summary>
  public object? Value { [DebuggerStepThrough] get; private set; }

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
