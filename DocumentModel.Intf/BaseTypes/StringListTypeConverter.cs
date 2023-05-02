namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

internal class StringListTypeConverter : TypeConverter
{
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    return destinationType == typeof(String);
  }

  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is StringList stringList)
    {
      if (destinationType == typeof(string))
      {
        return String.Join(" ", stringList.Select(item=>"\""+item+"\""));
      }
    }
    return base.ConvertTo(context, culture, value, destinationType);
  }

  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    if (sourceType == typeof(String))
      return true;
    return base.CanConvertFrom(context, sourceType);
  }

  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
    {
      var result = new StringList();
      str = str.Replace("\" \"", "\t");
      str = str.ReplaceStart("\"", "");
      str = str.ReplaceEnd("\"", "");
      var ss = str.Split('\t');
      foreach (var s in ss)
        result.Add(s);
      return result;
    }
    return base.ConvertFrom(context, culture, value);
  }

}