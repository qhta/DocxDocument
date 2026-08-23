namespace DocumentModel.Drawings;

public partial class PresetColor : IColor
{
  /// <summary>
  /// Value of the color as ARGB uint.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public override UInt32 ARGB
  {
    get => this.Index is null ? (uint)PresetColors.Auto : (UInt32)this.Index! ^ 0xFF000000;
    set
    {
      if (_presetColorLookup == null)
      {
        _presetColorLookup = new();
        var _presetColors = typeof(PresetColors).GetFields(BindingFlags.Public | BindingFlags.Static).Where(f => f.FieldType == typeof(PresetColors)).ToArray();
        foreach (var field in _presetColors)
        {
          var colorValue = (UInt32)field.GetValue(null)! ^ 0xFF000000;
          if (!_presetColorLookup.ContainsKey(colorValue))
            _presetColorLookup[colorValue] = (PresetColors)field.GetValue(null)!;
        }
      }

      var presetColorField = typeof(PresetColors).GetFields(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(f => ((UInt32)f.GetValue(null)! ^ 0xFF000000).Equals(value) == true);
      if (_presetColorLookup.TryGetValue(value, out var presetColor))
      {
        this.Index = presetColor!;
        return;
      }
      else
        throw new ArgumentException($"The provided ARGB value '{((uint)value):X6}' does not correspond to any known preset color.");
    }
  }
  private Dictionary<UInt32, PresetColors>? _presetColorLookup = null!;

}
