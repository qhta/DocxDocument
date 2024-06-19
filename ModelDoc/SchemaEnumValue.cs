using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

public class SchemaEnumValue
{

  [Key] public int Id { get; set; }

  public int SimpleTypeId { get; set; }

  [MaxLength(255)]
  public string? EnumValueName { get; set; }

  public int? EnumValueNum { get; set; }
}
