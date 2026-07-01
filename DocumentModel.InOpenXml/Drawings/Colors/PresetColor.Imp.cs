namespace DocumentModel.Drawings;
public partial class PresetColor : IColor
{
 /// <summary>
 /// Value of the color as RGB uint.
 /// </summary>
 [NotMapped]
 [XmlIgnore]
 [JsonIgnore]
 public override UInt32? RGB
 {
  get => this.Index is null ? null : (UInt32)this.Index!;
  set
  {
   if (value == null)
   {
    this.Index = null;
    return;
   }

   if (_presetColorLookup == null)
   {
    _presetColorLookup = new();
    var _presetColors = typeof(PresetColors).GetFields(BindingFlags.Public | BindingFlags.Static).Where(f => f.FieldType == typeof(PresetColors)).ToArray();
    foreach (var field in _presetColors)
    {
     var colorValue = (UInt32)field.GetValue(null)!;
     if (!_presetColorLookup.ContainsKey(colorValue))
      _presetColorLookup[colorValue] = (PresetColors)field.GetValue(null)!;
    }
   }

   var presetColorField = typeof(PresetColors).GetFields(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(f => ((UInt32)f.GetValue(null)!).Equals(value) == true);
   if (_presetColorLookup.TryGetValue(value.Value, out var presetColor))
   {
    this.Index = presetColor!;
    return;
   }
   else
    throw new ArgumentException($"The provided RGB value '{((uint)value):X6}' does not correspond to any known preset color.");
  }
 }
 private Dictionary<UInt32, PresetColors>? _presetColorLookup = null!;

}
