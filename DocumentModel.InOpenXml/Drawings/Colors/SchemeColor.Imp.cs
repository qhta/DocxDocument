namespace DocumentModel.Drawings;

public partial class SchemeColor : IColor
{
  /// <summary>
  /// Value of the color as RGB uint.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public override UInt32? RGB
  {
    get
    {
      if (_RGB != null)
        return _RGB;
      if (this.Index is null)
        return null;
      var ColorScheme = ParentDocument?.Theme?.ThemeElements?.ColorScheme?.GetColor(this.Index.Value);
      return (ColorScheme as ISchemeBaseColor)?.RGB;
    }

    set => _RGB = value;
  }
  private UInt32? _RGB;

  /// <summary>
  /// Name of the color. It may be used to specify a color by name, such as "Accent1", "Accent2", etc.
  /// If the color is not found in the SchemeColors enumeration, the exception is raised.
  /// </summary>
  public override string? Name
  {
    get
    {
      if (this.RGB is not null)
      {
        var schemeColorField = typeof(SchemeColors).GetFields(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(f => f.GetValue(null)?.Equals(this.RGB.Value) == true);
        return schemeColorField?.Name;
      }

      return null;
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
