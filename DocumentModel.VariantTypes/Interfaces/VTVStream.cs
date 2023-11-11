using System;

namespace DocumentModel.VariantTypes;

/// <summary>
/// VStream variant. Similar to Stream variant but with additional Version property
/// </summary>
public interface VTVStream: Variant
{
  /// <summary>
  /// <para>VSTREAM Version Attribute</para>
  /// </summary>
  public Guid? Version {get; set;}
}
