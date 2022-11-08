namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum PresetZoom
{
  None,
  FullPage,
  BestFit,
  TextFit,
}