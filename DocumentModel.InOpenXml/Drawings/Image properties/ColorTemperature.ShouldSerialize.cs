namespace DocumentModel.Drawings;

public partial class ColorTemperature
{
  public bool ShouldSerializeColorTemperatureValue() => ColorTemperatureValue is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
