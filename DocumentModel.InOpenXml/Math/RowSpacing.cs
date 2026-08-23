namespace DocumentModel.Math;
/// <summary>
/// This struct represents equation array row spacing rule and value.
/// </summary>
public struct RowSpacing
{
  /// <summary>
  /// Specifies the interpretation of Val property.
  /// </summary>
  public RowSpacingRule Rule { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Specifies numeric value for Exactly and Multiply rules.
  /// </summary>
  public UInt16? Value { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Default constructor - Rule set to Single.
  /// </summary>
  public RowSpacing() { }
  /// <summary>
  /// Value constructor
  /// </summary>
  public RowSpacing(RowSpacingRule rule, UInt16? val)
  {
    Rule = rule;
    Value = val;
  }
  /// <summary>
  /// Parsing constructor
  /// </summary>
  public RowSpacing(string str)
  {
    if (Char.IsLetter(str.FirstOrDefault()))
      Rule = Enum.Parse<RowSpacingRule>(str, true);
    else
    {
      if (str.EndsWith("ln"))
      {
        Value = (UInt16)(Double.Parse(str.Substring(0, str.Length - 2).Trim(), CultureInfo.InvariantCulture) * 2);
        Rule = RowSpacingRule.Multiple;
      }
      else if (str.EndsWith("pt"))
      {
        Value = UInt16.Parse(str.Substring(0, str.Length - 2).Trim());
        Rule = RowSpacingRule.Exactly;
      }
      else
      {
        Value = UInt16.Parse(str.Trim());
        Rule = RowSpacingRule.Exactly;
      }
    }
  }
  /// <summary>
  /// Convert to string.
  /// </summary>
  public override string? ToString()
  {
    switch (Rule)
    {
      case RowSpacingRule.Single:
        return "single";
      case RowSpacingRule.OneAndHalf:
        return "oneAndHalf";
      case RowSpacingRule.Double:
        return "double";
      case RowSpacingRule.Exactly:
        return $"{Value}pt";
      case RowSpacingRule.Multiple:
        double v = (Value ?? 0) / 2.0;
        return $"{v.ToString(CultureInfo.InvariantCulture)}ln";
    }
    return null;
  }
}
