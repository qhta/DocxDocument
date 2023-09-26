namespace ModelGenApp.Helpers;

/// <summary>
/// Helper class to represent filter for <see cref="ModelGenApp.TypeInfoViewModel"/>.
/// </summary>
public record TypeInfoViewModelFilter<T> : IFilter where T : TypeInfoViewModel
{


  public static bool CanFilter(TypeInfoKind filter)
  {
    if (filter == TypeInfoKind.AcceptedTypes)
      return true;
    if (filter == TypeInfoKind.RejectedTypes)
      return true;
    if (filter == TypeInfoKind.InvalidTypes)
      return true;
    if (filter == TypeInfoKind.TypesWithSameName)
      return true;
    if (filter == TypeInfoKind.RenamedTypes)
      return true;
    if (filter == TypeInfoKind.ConvertedTypes)
      return true;
    if (filter == TypeInfoKind.TargetTypes)
      return true;
    if (filter == TypeInfoKind.TypesWithoutDescription)
      return true;
    if (filter == TypeInfoKind.TypesWithMeaninglessDescription)
      return true;
    return false;
  }

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
    //if (filter == TypeInfoKind.TargetTypes)
    //  Debug.Assert(true);
    if (value is PPS phaseNum)
    {
      if (filter == TypeInfoKind.AcceptedTypes)
        Predicate = new Predicate<T>(item => item.Model.IsAcceptedAfter(phaseNum));
      else
      if (filter == TypeInfoKind.RejectedTypes)
        Predicate = new Predicate<T>(item => item.Model.IsRejectedAfter(phaseNum));
      else
      if (filter == TypeInfoKind.InvalidTypes)
        Predicate = new Predicate<T>(item => item.Model.IsInvalid(phaseNum));
      else
      if (filter == TypeInfoKind.TypesWithoutDescription)
        Predicate = new Predicate<T>(item => String.IsNullOrEmpty(item.Model.Description));
      else
      if (filter == TypeInfoKind.TypesWithMeaninglessDescription)
        Predicate = new Predicate<T>(item => item.Model.IsInvalid(phaseNum) && item.Model.Description != null && item.Model.Description.Trim() != "");
      else
      if (filter == TypeInfoKind.RenamedTypes)
        Predicate = new Predicate<T>(item => item.Model.NewName != null);
      else
      if (filter == TypeInfoKind.TypesWithSameName)
        Predicate = new Predicate<T>(item => item.Model.HasError(PPS.Rename, ErrorCode.MultiplicatedName));
      else
      if (filter == TypeInfoKind.ConvertedTypes)
        Predicate = new Predicate<T>(item => item.Model.TargetType!= null);
    }
    else
    if (value is FullTypeName typeName)
    {
      if (filter == TypeInfoKind.TypesWithSameName)
        Predicate = new Predicate<T>(item => item.Model.GetFullName(true, false, false) == typeName);
    }
    else
    {
      if (filter == TypeInfoKind.RenamedTypes)
        Predicate = new Predicate<T>(item => item.Model.IsConverted);
      else
      if (filter == TypeInfoKind.ConvertedTypes)
        Predicate = new Predicate<T>(item => item.Model.IsConverted);
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
