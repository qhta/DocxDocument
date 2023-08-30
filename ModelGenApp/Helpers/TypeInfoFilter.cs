namespace ModelGenApp.Helpers;

/// <summary>
/// Helper class to represent filter for <see cref="ModelGen.TypeInfo"/>.
/// </summary>
public record TypeInfoFilter
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
  public TypeInfoFilter(TypeInfoKind filter, object? value)
  {
    if (value is PPS phaseNum)
    {
      if (filter == TypeInfoKind.AcceptedTypes)
        Predicate = new Predicate<TypeInfo>(item => item.IsAcceptedAfter(phaseNum));
      else
      if (filter == TypeInfoKind.RejectedTypes)
        Predicate = new Predicate<TypeInfo>(item => item.IsRejectedAfter(phaseNum));
      else
      if (filter == TypeInfoKind.ProblematicTypes)
        Predicate = new Predicate<TypeInfo>(item => item.HasProblems(phaseNum));
    }
    else
    if (value is FullTypeName typeName)
    {
      if (filter == TypeInfoKind.TypesWithSameName)
        Predicate = new Predicate<TypeInfo>(item => item.GetFullName(true, false, false) == typeName);
    }
    else
    {
      if (filter == TypeInfoKind.RenamedTypes)
        Predicate = new Predicate<TypeInfo>(item => item.IsConverted);
      else
      if (filter == TypeInfoKind.ConvertedTypes)
        Predicate = new Predicate<TypeInfo>(item => item.IsConverted);
    }
    if (Predicate == null)
        throw new InvalidOperationException($"Can't create TypeInfoFilter with TypeInfoKind.{filter}");

    Caption = CommonStrings.ResourceManager.GetString(filter.ToString(), CultureInfo.CurrentUICulture) ?? filter.ToString();

    Value = value;
  }
  

  //ValidatedTypes,
  //ValidTypes,
  //InvalidTypes,
  //TypesWithDescription,
  //TypesWithAddedDescription,
  //TypesWithoutDescription,
  //TypesWithMeaninglessDescription,
  //TypesWithSameName,
  //RenamedTypes,
  //ConvertedTypes,
  public string Caption { get; set; } = null!;

  /// <summary>
  /// Initializing constructor with known predicate.
  public TypeInfoFilter(Predicate<TypeInfo> predicate)
  {
    Predicate = predicate;
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
