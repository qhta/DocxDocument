namespace DocumentModel.Drawings;

public partial class RgbColorModelHex : IColor
{
  /// <summary>
  /// Value of the color as RGB uint.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public override UInt32? RGB { get => (UInt32)this.Value!; set => this.Value = value ?? 0xFF000000; }

}
