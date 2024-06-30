using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelXmlSchema;

/// <summary>
/// Struct used to represent a type reference.
/// </summary>
public struct TypeRef
{
  /// <summary>
  /// Identifier of the namespace of the type.
  /// </summary>
  public int ns;

  /// <summary>
  /// Name of the type
  /// </summary>
  public string name;
}
