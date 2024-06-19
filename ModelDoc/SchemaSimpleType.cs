using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace ModelDoc;

public class SchemaSimpleType : SchemaType
{
  public int? MinLength { get; set; }

  public int? Length { get; set; }

  public int? MaxLength { get; set; }

  public decimal? MinExclusive { get; set; }

  public decimal? MinInclusive { get; set; }

  public decimal? MaxInclusive { get; set; }

  public decimal? MaxExclusive { get; set; }

}
