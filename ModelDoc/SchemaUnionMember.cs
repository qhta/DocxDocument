using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

public class SchemaUnionMember
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
  public int? MemberNamespaceId
  {
    get; set;
  }

  [MaxLength(255)]
  public string? MemberTypeName
  {
    get; set;
  }
}
