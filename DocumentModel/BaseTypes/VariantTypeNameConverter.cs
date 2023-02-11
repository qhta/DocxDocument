using System.Xml;

using Newtonsoft.Json.Linq;

namespace DocumentModel;

internal class VariantTypeNameConverter : TypeConverter
{
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    if (destinationType == typeof(String))
      return true;
    return base.CanConvertTo(context, destinationType);
  }

  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  { 
   object? result;
    if (destinationType == typeof(String) && value is VariantType variantType)
      result = variantType.ToString(CultureInfo.InvariantCulture);
    else
      result = base.ConvertTo(context, culture, value, destinationType); 
    return result;
  }

  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    if (sourceType == typeof(string))
      return true;
    if (sourceType == typeof(Type))
      return true;
    return base.CanConvertFrom(context, sourceType);
  }

  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is Type type)
      value = type.Name;
    if (value is string str)
    {
      if (str == "VectorVariant")
        return VariantType.Vector;
      if (str == "ArrayVariant")
        return VariantType.Array;
      if (str == "Byte[]")
        return VariantType.Blob;
      if (Enum.TryParse<VariantType>(str, out var variantType))
        return variantType;
    }
    return null;
  }

}