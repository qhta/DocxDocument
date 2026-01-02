namespace DocumentModel.Wordprocessing;
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
    if (destinationType == typeof(string) && value is ILanguages language)
      return language.Regular + ";" + language.ComplexScript + ";" + language.EastAsia;
    return base.ConvertTo(context, culture, value, destinationType);
  }
  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
    {
      var ss = new List<string?>(str.Split(';'));
      for (int i=0; i<ss.Count; i++)
        if (ss[i] == "")
          ss[i]=null;
      while (ss.Count < 3)
        ss.Add(null);
      return new ILanguages{ Regular = ss[0], ComplexScript = ss[1], EastAsia = ss[2] };
    }
    return base.ConvertFrom(context, culture, value);
  }
}
