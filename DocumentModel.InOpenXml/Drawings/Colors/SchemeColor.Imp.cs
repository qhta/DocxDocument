namespace DocumentModel.Drawings;

public partial class SchemeColor : IColor
{
  /// <summary>
  /// Value of the color as RGB uint.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public override UInt32 ARGB
  {
    get
    {
      IColor? colorScheme = null;
      if (this.Index is not null)
        colorScheme = ParentDocument?.Theme?.ThemeElements?.ColorScheme?.GetColor(this.Index.Value);
      return (colorScheme as IColor)?.ARGB ??
             (uint)((uint?)LastColor ^ 0xFF000000 ?? (uint)PresetColors.Auto ^ 0xFF000000);
    }
    set => LastColor = value ^ 0xFF000000;
  }

  /// <summary>
  /// Name of the color. It may be used to specify a color by name, such as "Accent1", "Accent2", etc.
  /// If the color is not found in the SchemeColors enumeration, the exception is raised.
  /// </summary>
  public override string? Name
  {
    get
    {
      var schemeColorField = typeof(SchemeColors).GetFields(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(f => f.GetValue(null)?.Equals(this.ARGB ^ 0xFF000000) == true);
      return schemeColorField?.Name;
    }

    set
    {
      if (value is null)
        return;
      if (Enum.TryParse<SchemeColors>(value, out var schemeColor))
      {
        this.Index = schemeColor;
        return;
      }

      throw new ArgumentException($"The provided color name '{value}' is not recognized as a valid scheme color.");
    }
  }

}
