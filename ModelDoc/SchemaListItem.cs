using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

public class SchemaListItem
{

  [Key]
  public int Id
  {
    get; set;
  }

  public int SimpleTypeId
  {
    get; set;
  }
  public int? ItemNamespaceId
  {
    get; set;
  }

  [MaxLength(255)]
  public string? ItemTypeName
  {
    get; set;
  }
}
