using System;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Variant. Value is of any type.
/// </summary>
public interface Variant: IConvertible
{
  public object? Value { get; set; }
  
}
