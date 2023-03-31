namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
public class LanguagesTypeConverter: TypeConverter
{
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    return destinationType == typeof(string);
  }

  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    return sourceType == typeof(string);
  }

  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (destinationType == typeof(string) && value is Languages language)
      return language.Normal + ";" + language.EastAsia + ";" + language.Bidi;
    return base.ConvertTo(context, culture, value, destinationType);
  }

  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
    {
      var ss = str.Split(';').ToList();
      while (ss.Count < 3)
        ss.Add(ss.Last());
      return new Languages{ Normal = ss[0], EastAsia = ss[1], Bidi = ss[2] };
    }
    return base.ConvertFrom(context, culture, value);
  }
}
