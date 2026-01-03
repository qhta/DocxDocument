namespace DocumentModel.Drawings;

public interface ThemeColor: Color2Type, INamedObject, IEquatable<ThemeColor>
{
  public string? Name { get; set; }

  public Color2Type? Value { get; set; }

}