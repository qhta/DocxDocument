namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum MathJustification
{
    Left,
    Right,
    Center,
    CenterGroup,
}