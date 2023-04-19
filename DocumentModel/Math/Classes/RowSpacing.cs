namespace DocumentModel.Math;

/// <summary>
/// This struct represents equation array row spacing rule and value.
/// </summary>
[TypeConverter(typeof(RowSpacingTypeConverter))]
public struct RowSpacing
{
  /// <summary>
  /// Specifies the interpretation of Val property.
  /// </summary>
  public RowSpacingRuleKind Rule { get; set; }
  /// <summary>
  /// Specifies numeric value for Exactly and Multiply rules.
  /// </summary>
  public UInt16? Value { get; set; }

  /// <summary>
  /// Default constructor - Rule set to Single.
  /// </summary>
  public RowSpacing() { }

  /// <summary>
  /// Value constructor
  /// </summary>
  public RowSpacing(RowSpacingRuleKind rule, UInt16? val)
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
      Rule = Enum.Parse<RowSpacingRuleKind>(str, true);
    else
    {
      if (str.EndsWith("ln"))
      {
        Value = (UInt16)(Double.Parse(str.Substring(0,str.Length-2).Trim(), CultureInfo.InvariantCulture)*2);
        Rule = RowSpacingRuleKind.Multiple;
      }
      else if (str.EndsWith("pt"))
      {
        Value = UInt16.Parse(str.Substring(0,str.Length-2).Trim());
        Rule = RowSpacingRuleKind.Exactly;
      }
      else
      {
        Value = UInt16.Parse(str.Trim());
        Rule = RowSpacingRuleKind.Exactly;
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
      case RowSpacingRuleKind.Single:
        return "single";
      case RowSpacingRuleKind.OneAndHalf:
        return "oneAndHalf";
      case RowSpacingRuleKind.Double:
        return "double";
      case RowSpacingRuleKind.Exactly:
        return $"{Value}pt";
      case RowSpacingRuleKind.Multiple:
        double v = (Value ?? 0) / 2.0;
        return $"{v.ToString(CultureInfo.InvariantCulture)}ln";
    }
    return null;
  }
}
