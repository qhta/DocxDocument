namespace ModelGenApp.Helpers;

/// <summary>
/// Helper class to represent filter for <see cref="ModelGen.PropInfo"/>.
/// </summary>
public record MemberInfoViewModelFilter: IFilter
{
  /// <summary>
  /// Initializing constructor. Creates <see cref="Predicate"/> on base of <paramref name="filter"/>.
  /// </summary>
  /// <param name="filter">Must be one of <see cref="MemberInfoKind"/> enumerations.</param>
  /// <param name="value">
  ///   Must be <see cref="ModelGen.PPS"/> for "AcceptedMembers", "RejectedMembers", and "InvalidMembers" filter.
  ///   Must be string for "MembersWithDuplicateName" filter.
  /// </param>
  /// <exception cref="InvalidOperationException"></exception>
  public MemberInfoViewModelFilter(MemberInfoKind filter, object? value)
  {
    if (value is PPS phaseNum)
    {
      if (filter == MemberInfoKind.AcceptedMembers)
        Predicate = new Predicate<object>(obj => 
        (obj is PropInfoViewModel pvm) && pvm.Model.IsAcceptedAfter(phaseNum)
        || (obj is EnumInfoViewModel evm) && evm.Model.IsAcceptedAfter(phaseNum));
      else
      if (filter == MemberInfoKind.RejectedMembers)
        Predicate = new Predicate<object>(obj => 
        (obj is PropInfoViewModel pvm) && pvm.Model.IsRejectedAfter(phaseNum)
        || (obj is EnumInfoViewModel evm) && evm.Model.IsRejectedAfter(phaseNum));
      else
      if (filter == MemberInfoKind.ProblematicMembers)
        Predicate = new Predicate<object>(obj => 
        (obj is PropInfoViewModel pvm) && pvm.Model.IsInvalid(phaseNum)
        || (obj is EnumInfoViewModel evm) && evm.Model.IsInvalid(phaseNum));
    }
    else
    if (value is FullTypeName propName)
    {
      if (filter == MemberInfoKind.MembersWithSameName)
        Predicate = new Predicate<object>(obj => 
        (obj is PropInfoViewModel pvm) && pvm.Model.GetTargetName() == propName
        /*|| (obj is EnumInfoViewModel evm) && evm.Model.GetTargetName() == propName*/);
    }
    else
    {
      if (filter == MemberInfoKind.RenamedMembers)
        Predicate = new Predicate<object>(obj => 
        (obj is PropInfoViewModel pvm) && pvm.Model.IsRenamed
        || (obj is EnumInfoViewModel evm) && evm.Model.IsRenamed);
      else
      if (filter == MemberInfoKind.ConvertedMembers)
        Predicate = new Predicate<object>(obj => 
        (obj is PropInfoViewModel pvm) && pvm.Model.IsConverted
        || (obj is EnumInfoViewModel evm) && evm.Model.IsConverted);
    }
    if (Predicate == null)
        throw new InvalidOperationException($"Can't create PropInfoFilter with MemberInfoKind.{filter}");

    Caption = CommonStrings.ResourceManager.GetString(filter.ToString(), CultureInfo.CurrentUICulture) ?? filter.ToString();

    Value = value;
  }
  

  //ValidatedMembers,
  //ValidMembers,
  //InvalidMembers,
  //MembersWithDescription,
  //MembersWithAddedDescription,
  //MembersWithoutDescription,
  //MembersWithMeaninglessDescription,
  //MembersWithSameName,
  //RenamedMembers,
  //ConvertedMembers,
  public string Caption { [DebuggerStepThrough] get; set; } = null!;

  /// <summary>
  /// Initializing constructor with known predicate.
  public MemberInfoViewModelFilter(Predicate<object> predicate)
  {
    Predicate = predicate;
  }

  /// <summary>
  /// Predicate to apply in filtering.
  /// </summary>
  public Predicate<object> Predicate { [DebuggerStepThrough] get; private set; } = null!;

  /// <summary>
  /// A parameter for predicate.
  /// </summary>
  public object? Value { [DebuggerStepThrough] get; private set; }

  public Predicate<object> GetPredicate()
  {
    return Predicate;
  }

  public bool Accept(object item)
  {
    return Predicate.Invoke(item);
  }
}
