namespace DocumentModel.Drawings;

public partial class RgbColorModelHex : IColor
{
  /// <summary>
  /// Value of the color as ARGB uint.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public override UInt32 ARGB { get => (UInt32)this.Value ^ 0xFF000000; set => this.Value = (value ^ 0xFF000000); }

}
