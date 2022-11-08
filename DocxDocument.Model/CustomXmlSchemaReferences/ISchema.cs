namespace DocxDocument.Model;

public interface ISchema
{
  public string? ManifestLocation { get; set; }
  public string? SchemaLocation { get; set; }
  public string? Uri { get; set; }

}