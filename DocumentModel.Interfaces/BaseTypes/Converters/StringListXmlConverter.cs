using System.ComponentModel;
using System.Globalization;

namespace DocumentModel;

/// <summary>
///   XML type converter that handles conversion between StringList collections and space-separated quoted string format.
/// </summary>
/// <remarks>
///   <para>
///   This converter transforms StringList objects to and from a specialized XML string format where
///   individual string items are enclosed in double quotes and separated by spaces. This format is
///   commonly used in Office Open XML documents for properties that contain multiple string values.
///   </para>
///   <para>
///   <b>Format Specification:</b>
///   <list type="bullet">
///   <item><description>Each string item is wrapped in double quotes: "item"</description></item>
///   <item><description>Multiple items are separated by single spaces: "item1" "item2" "item3"</description></item>
///   <item><description>Empty strings are represented as empty quotes: ""</description></item>
///   <item><description>Spaces within items are preserved: "item with spaces"</description></item>
///   </list>
///   </para>
///   <para>
///   <b>Conversion Examples:</b>
///   <list type="bullet">
///   <item><description>StringList { "Hello", "World" } ⇄ "Hello" "World"</description></item>
///   <item><description>StringList { "First Item", "Second" } ⇄ "First Item" "Second"</description></item>
///   <item><description>StringList { "A", "B", "C" } ⇄ "A" "B" "C"</description></item>
///   <item><description>StringList { "" } ⇄ ""</description></item>
///   </list>
///   </para>
///   <para>
///   This converter is used by the XML serialization framework to handle StringList properties
///   in Office Open XML document parts, ensuring consistent representation of multi-value string
///   attributes and elements.
///   </para>
/// </remarks>
public class StringListXmlConverter : TypeConverter
{
  /// <summary>
  ///   Determines whether this converter can convert a StringList to the specified destination type.
  /// </summary>
  /// <param name="context">
  ///   An <see cref="ITypeDescriptorContext"/> that provides a format context. This parameter can be null.
  /// </param>
  /// <param name="destinationType">
  ///   A <see cref="Type"/> that represents the type to convert to.
  /// </param>
  /// <returns>
  ///   <see langword="true"/> if the destination type is <see cref="String"/>; otherwise <see langword="false"/>.
  /// </returns>
  /// <remarks>
  ///   This converter only supports conversion to string type, which produces the space-separated
  ///   quoted string format required for XML serialization.
  /// </remarks>
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    return destinationType == typeof(String);
  }

  /// <summary>
  ///   Converts a StringList value to a space-separated quoted string format.
  /// </summary>
  /// <param name="context">
  ///   An <see cref="ITypeDescriptorContext"/> that provides a format context. This parameter can be null.
  /// </param>
  /// <param name="culture">
  ///   A <see cref="CultureInfo"/>. If null is passed, the current culture is assumed.
  /// </param>
  /// <param name="value">
  ///   The StringList object to convert.
  /// </param>
  /// <param name="destinationType">
  ///   The <see cref="Type"/> to convert to. This should be <see cref="String"/>.
  /// </param>
  /// <returns>
  ///   A string where each StringList item is enclosed in double quotes and separated by spaces,
  ///   or null if the value is null or not a StringList.
  /// </returns>
  /// <remarks>
  ///   <para>
  ///   The conversion process:
  ///   <list type="number">
  ///   <item><description>Each string item in the list is wrapped with double quotes</description></item>
  ///   <item><description>Items are joined with single space characters</description></item>
  ///   <item><description>The resulting format: "item1" "item2" "item3"</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   Example: StringList containing ["Hello", "World"] converts to the string: "Hello" "World"
  ///   </para>
  /// </remarks>
  /// <exception cref="NotSupportedException">
  ///   Thrown when destinationType is not <see cref="String"/>.
  /// </exception>
  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is StringList stringList)
    {
      if (destinationType == typeof(string))
      {
        return String.Join(" ", stringList.Select(item => "\"" + item + "\""));
      }
    }
    return base.ConvertTo(context, culture, value, destinationType);
  }

  /// <summary>
  ///   Determines whether this converter can convert from the specified source type to a StringList.
  /// </summary>
  /// <param name="context">
  ///   An <see cref="ITypeDescriptorContext"/> that provides a format context. This parameter can be null.
  /// </param>
  /// <param name="sourceType">
  ///   A <see cref="Type"/> that represents the type to convert from.
  /// </param>
  /// <returns>
  ///   <see langword="true"/> if the source type is <see cref="String"/>; otherwise <see langword="false"/>.
  /// </returns>
  /// <remarks>
  ///   This converter only supports conversion from string type, which must be in the space-separated
  ///   quoted string format.
  /// </remarks>
  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    if (sourceType == typeof(String))
      return true;
    return base.CanConvertFrom(context, sourceType);
  }

  /// <summary>
  ///   Converts a space-separated quoted string to a StringList collection.
  /// </summary>
  /// <param name="context">
  ///   An <see cref="ITypeDescriptorContext"/> that provides a format context. This parameter can be null.
  /// </param>
  /// <param name="culture">
  ///   A <see cref="CultureInfo"/>. If null is passed, the current culture is assumed.
  /// </param>
  /// <param name="value">
  ///   The string to convert. Must be in the format: "item1" "item2" "item3"
  /// </param>
  /// <returns>
  ///   A StringList containing the parsed string items, or null if the value is null or not a string.
  /// </returns>
  /// <remarks>
  ///   <para>
  ///   The conversion process:
  ///   <list type="number">
  ///   <item><description>The input string is parsed to identify quoted items: "item1" "item2"</description></item>
  ///   <item><description>Quote pairs separated by spaces are replaced with tab characters for splitting</description></item>
  ///   <item><description>Leading and trailing quotes are removed from the entire string</description></item>
  ///   <item><description>The string is split on tab characters to extract individual items</description></item>
  ///   <item><description>Each item is added to the resulting StringList</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   Example: The string "Hello" "World" converts to StringList containing ["Hello", "World"]
  ///   </para>
  ///   <para>
  ///   <b>Note:</b> This implementation uses tab characters as temporary delimiters during parsing.
  ///   The input format must follow the standard quoted string pattern with space separators.
  ///   </para>
  /// </remarks>
  /// <exception cref="NotSupportedException">
  ///   Thrown when the source type is not <see cref="String"/>.
  /// </exception>
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