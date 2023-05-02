namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
/// Type converter for EffectExtent type.
/// </summary>
internal class EffectExtentTypeConverter : TypeConverter
{
  /// <summary>
  /// Determines if a value can be converted from source type.
  /// </summary>
  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    if (sourceType == typeof(string))
      return true;
    return base.CanConvertFrom(context, sourceType);
  }

  /// <summary>
  /// Determines if a value can be converted to destination type.
  /// </summary>
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    if (destinationType == typeof(string))
      return true;
    return base.CanConvertTo(context, destinationType);
  }

  /// <summary>
  /// Converts the string value to Extent object.
  /// </summary>
  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
    {
      var ss = str.Split(';');
      if (ss.Length == 1)
        return new EffectExtent { LeftEdge = new EMU(ss[0]), TopEdge = new EMU(ss[0]), RightEdge = new EMU(ss[0]), BottomEdge = new EMU(ss[0]) };
      else
      if (ss.Length == 2)
        return new EffectExtent { LeftEdge = new EMU(ss[0]), TopEdge = new EMU(ss[1]), RightEdge = new EMU(ss[0]), BottomEdge = new EMU(ss[1]) };
      else
      if (ss.Length == 3)
        throw new InvalidOperationException($"Can't convert \"{str}\" to EffectExtent. There should be one, two or four numbers separated by semicolons");
      else
        return new EffectExtent { LeftEdge = new EMU(ss[0]), TopEdge = new EMU(ss[1]), RightEdge = new EMU(ss[2]), BottomEdge = new EMU(ss[3]) };
    }
    return base.ConvertFrom(context, culture, value);
  }

  /// <summary>
  /// Converts the Extent object to string value.
  /// </summary>
  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is EffectExtent extent)
    {
      if (extent.LeftEdge == extent.RightEdge && extent.TopEdge == extent.BottomEdge)
      {
        if (extent.LeftEdge == extent.TopEdge)
          return $"{extent.LeftEdge}";
        else
          return $"{extent.LeftEdge};{extent.TopEdge}";
      }
      return $"{extent.LeftEdge};{extent.TopEdge};{extent.RightEdge};{extent.BottomEdge}";
    }
    return base.ConvertTo(context, culture, value, destinationType);
  }

}