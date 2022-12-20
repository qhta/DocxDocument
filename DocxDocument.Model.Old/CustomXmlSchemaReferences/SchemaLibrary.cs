
namespace DocxDocument.Model;

public class SchemaLibrary : DocxBasedCollection<DM.Schema, ISchema, CX.SchemaLibrary, CX.Schema>, ISchemaLibrary
{

  public SchemaLibrary() : base(new CX.SchemaLibrary())
  {
  }

  public SchemaLibrary(CX.SchemaLibrary element): base(element)
  {
  }
}