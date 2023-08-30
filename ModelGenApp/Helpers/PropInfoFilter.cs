namespace ModelGenApp.Helpers;

/// <summary>
/// Helper class to represent filter for <see cref="ModelGen.PropInfo"/>.
/// </summary>
public record PropInfoFilter
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
  public PropInfoFilter(MemberInfoKind filter, object? value)
  {
    if (value is PPS phaseNum)
    {
      if (filter == MemberInfoKind.AcceptedMembers)
        Predicate = new Predicate<PropInfo>(item => item.IsAcceptedAfter(phaseNum));
      else
      if (filter == MemberInfoKind.RejectedMembers)
        Predicate = new Predicate<PropInfo>(item => item.IsRejectedAfter(phaseNum));
      else
      if (filter == MemberInfoKind.ProblematicMembers)
        Predicate = new Predicate<PropInfo>(item => item.HasProblems(phaseNum));
    }
    else
    if (value is FullTypeName propName)
    {
      if (filter == MemberInfoKind.MembersWithSameName)
        Predicate = new Predicate<PropInfo>(item => item.GetTargetName() == propName);
    }
    else
    {
      if (filter == MemberInfoKind.RenamedMembers)
        Predicate = new Predicate<PropInfo>(item => item.IsConverted);
      else
      if (filter == MemberInfoKind.ConvertedMembers)
        Predicate = new Predicate<PropInfo>(item => item.IsConverted);
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
  public string Caption { get; set; } = null!;

  /// <summary>
  /// Initializing constructor with known predicate.
  public PropInfoFilter(Predicate<PropInfo> predicate)
  {
    Predicate = predicate;
  }

  /// <summary>
  /// Predicate to apply in filtering.
  /// </summary>
  public Predicate<PropInfo> Predicate { get; private set; } = null!;

  /// <summary>
  /// A parameter for predicate.
  /// </summary>
  public object? Value { get; private set; }
}
