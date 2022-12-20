using DocumentFormat.OpenXml;

namespace DocxDocument.Model;

public class Schema: IDocxBasedElement, ISchema
{
  public Schema()
  {
    WdSchema = new CX.Schema();
  }

  public Schema(CX.Schema wdSchema)
  {
    WdSchema = wdSchema;
  }

  public OpenXmlElement OpenXmlElement { get => WdSchema; set => WdSchema = (CX.Schema)value; }

  public CX.Schema WdSchema { get; set; }

  public string? ManifestLocation { get => WdSchema.ManifestLocation; set => WdSchema.ManifestLocation = value; }

  public string? SchemaLocation { get => WdSchema.SchemaLocation; set => WdSchema.SchemaLocation = value; }

  public string? Uri { get => WdSchema.Uri; set => WdSchema.Uri = value; }

}