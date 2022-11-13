
using DocumentFormat.OpenXml;

using DocxDocument.Model;

using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;

namespace DocxDocument.Reader;

public static partial class DocxRead
{
  public const string wordUrl = "http://schemas.openxmlformats.org/wordprocessingml/2006/main";


  #region String read/write

  public static string? ReadStringType<ElementType>(this OO.OpenXmlCompositeElement parent) where ElementType : WD.StringType
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
    {
      if (element.Val?.HasValue == true)
        return element?.Val?.Value;
    }
    return null;
  }

  public static void WriteStringType<ElementType>(this OO.OpenXmlCompositeElement parent, string? value) where ElementType : WD.StringType, new()
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
      element.Remove();
    if (value != null)
      parent.AddChild(new ElementType { Val = value });
  }

  public static string? ReadString253Type<ElementType>(this OO.OpenXmlCompositeElement parent) where ElementType : WD.String253Type
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
    {
      if (element.Val?.HasValue == true)
        return element?.Val?.Value;
    }
    return null;
  }

  public static void WriteString253Type<ElementType>(this OO.OpenXmlCompositeElement parent, string? value) where ElementType : WD.String253Type, new()
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
      element.Remove();
    if (value != null)
      parent.AddChild(new ElementType { Val = value });
  }
  #endregion

  #region bool read/write

  public static bool? ReadOnOffType<ElementType>(this OO.OpenXmlCompositeElement parent) where ElementType : WD.OnOffType
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
    {
      if (element.Val?.HasValue == true)
        return element?.Val?.Value;
      else
        return true;
    }
    return null;
  }

  public static void WriteOnOffType<ElementType>(this OO.OpenXmlCompositeElement parent, bool? value) where ElementType : WD.OnOffType, new()
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
      element.Remove();
    if (value != null)
      parent.AddChild(new ElementType { Val = value });
  }

  public static bool? ReadW14OnOffType<ElementType>(this OO.OpenXmlCompositeElement parent) where ElementType : W14.OnOffType
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
    {
      if (element.Val?.HasValue == true)
        return element?.Val?.Value is W14.OnOffValues.True or W14.OnOffValues.One;
      else
        return true;
    }
    return null;
  }

  public static void WriteW14OnOffType<ElementType>(this OO.OpenXmlCompositeElement parent, bool? value) where ElementType : W14.OnOffType, new()
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
      element.Remove();
    if (value != null)
      parent.AddChild(new ElementType { Val = (bool)value ? W14.OnOffValues.One : W14.OnOffValues.Zero });
  }

  public static bool? ReadEmptyAsBool<ElementType>(this OO.OpenXmlCompositeElement parent) where ElementType : WD.EmptyType
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
    {
      return true;
    }
    return null;
  }

  public static void WriteEmptyAdBool<ElementType>(this OO.OpenXmlCompositeElement parent, bool? value) where ElementType : WD.EmptyType, new()
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
      element.Remove();
    if (value != null)
      parent.AddChild(new ElementType ());
  }

  #endregion

  #region Integer read/write

  public static int? ReadUnsignedInt7Type<ElementType>(this OO.OpenXmlCompositeElement parent) where ElementType : WD.UnsignedInt7Type
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
    {
      if (element.Val?.HasValue == true)
        return element?.Val?.Value;
    }
    return null;
  }

  public static void WriteUnsignedInt7Type<ElementType>(this OO.OpenXmlCompositeElement parent, int? value) where ElementType : WD.UnsignedInt7Type, new()
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
      element.Remove();
    if (value != null)
      parent.AddChild(new ElementType { Val = value });
  }

  public static int? ReadUnsignedDecimalNumberType<ElementType>(this OO.OpenXmlCompositeElement parent) where ElementType : WD.UnsignedDecimalNumberType
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
    {
      if (element.Val?.HasValue == true)
        return (int?)element?.Val?.Value;
    }
    return null;
  }

  public static void WriteUnsignedDecimalNumberType<ElementType>(this OO.OpenXmlCompositeElement parent, int? value) where ElementType : WD.UnsignedDecimalNumberType, new()
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
      element.Remove();
    if (value != null)
      parent.AddChild(new ElementType { Val = (uint)value });
  }

  public static int? ReadTwipsMeasureType<ElementType>(this OO.OpenXmlCompositeElement parent) where ElementType : WD.TwipsMeasureType
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element is not null)
    {
      return int.Parse(element.Val?.Value);
    }
    return null;
  }

  public static void WriteTwipsMeasureType<ElementType>(this OO.OpenXmlCompositeElement parent, int? value) where ElementType : WD.TwipsMeasureType, new()
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
      element.Remove();
    if (value != null)
    {
      parent.AddChild(new ElementType { Val = value.ToString() });
    }
  }

  public static int? ReadNonNegativeShortType<ElementType>(this OO.OpenXmlCompositeElement parent) where ElementType : WD.NonNegativeShortType
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element is not null)
    {
      return (int?)element.Val?.Value;
    }
    return null;
  }

  public static void WriteNonNegativeShortType<ElementType>(this OO.OpenXmlCompositeElement parent, int? value) where ElementType : WD.NonNegativeShortType, new()
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
      element.Remove();
    if (value != null)
    {
      parent.AddChild(new ElementType { Val = (short)value });
    }
  }

  public static int? ReadInteger<ElementType>(this OO.OpenXmlCompositeElement parent) where ElementType : OO.OpenXmlLeafElement
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
    {
      var valProp = typeof(ElementType).GetProperty("Val", BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
      if (valProp == null)
        throw new InvalidOperationException($"{typeof(ElementType).Name} does not have Val property");
      var valObj = valProp.GetValue(element, null);
      if (valObj is Int32Value valInt)
        if (valInt.HasValue)
          return valInt.Value;
    }
    return null;
  }

  public static void WriteInteger<ElementType>(this OO.OpenXmlCompositeElement parent, int? value) where ElementType : OO.OpenXmlLeafElement, new()
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
      element.Remove();
    if (value != null)
    {
      var newElement = new ElementType();
      var valProp = typeof(ElementType).GetProperty("Val");
      if (valProp == null)
        throw new InvalidOperationException($"{typeof(ElementType).Name} does not have Val property");
      valProp.SetValue(newElement, (int)value);
      parent.AddChild(newElement);
    }
  }
  #endregion

  #region Percentage read/write

  public static DM.Percentage? ReadPercentage<ElementType>(this OO.OpenXmlCompositeElement parent) where ElementType : OO.OpenXmlLeafElement
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
    {
      var valProp = typeof(ElementType).GetProperty("Val", BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
      if (valProp == null)
        throw new InvalidOperationException($"{typeof(ElementType).Name} does not have Val property");
      var valObj = valProp.GetValue(element, null);
      if (valObj is Int32Value valInt)
        if (valInt.HasValue)
          return valInt.Value;
    }
    return null;
  }

  public static void WritePercentage<ElementType>(this OO.OpenXmlCompositeElement parent, DM.Percentage? value)
    where ElementType : OO.OpenXmlLeafElement, new()
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
      element.Remove();
    if (value != null)
    {
      var newElement = new ElementType();
      var valProp = typeof(ElementType).GetProperty("Val");
      if (valProp == null)
        throw new InvalidOperationException($"{typeof(ElementType).Name} does not have Val property");
      valProp.SetValue(newElement, (int)value);
      parent.AddChild(newElement);
    }
  }
  #endregion

  #region Enum Flags read/write

  public static EnumType? ReadEnumFlags<EnumType, ElementType>(this OO.OpenXmlCompositeElement parent)
    where EnumType : struct, IConvertible where ElementType : OO.OpenXmlLeafElement
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
    {
      var result = default(EnumType);
      var intType = typeof(EnumType).GetEnumUnderlyingType();
      foreach (var prop in typeof(ElementType).GetProperties())
      {
        if (prop.PropertyType == typeof(OO.OnOffValue))
        {
          var propValue = prop.GetValue(element, null);
          if (propValue is OO.OnOffValue onOffValue)
          {
            var val = ReadBoolean(onOffValue);
            if (val == true)
            {
              var enumVal = typeof(EnumType).GetField(prop.Name, BindingFlags.Public | BindingFlags.Static)?.GetValue(null);
              if (enumVal is EnumType enumTypeVal)
              {
                result = (EnumType)(object)((Int32)Convert.ChangeType(result, intType) | (Int32)Convert.ChangeType(enumTypeVal, intType));
              }
            }
          }
        }
      }
      return result;
    }
    return null;
  }

  public static void WriteEnumFlags<EnumType, ElementType>(this OO.OpenXmlCompositeElement parent, EnumType? value)
    where EnumType : struct, IConvertible where ElementType : OO.OpenXmlLeafElement, new()
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
      element.Remove();
    if (value is not null)
    {
      element = new ElementType();
      foreach (var prop in typeof(ElementType).GetProperties())
      {
        if (prop.PropertyType == typeof(OO.OnOffValue))
        {
          var enumVal = typeof(EnumType).GetField(prop.Name, BindingFlags.Public | BindingFlags.Static)?.GetValue(null);
          if (enumVal is EnumType enumTypeVal)
          {
            var val =
              ((UInt64)Convert.ChangeType(value, typeof(UInt64)) & (UInt64)Convert.ChangeType(enumTypeVal, typeof(UInt64))) ==
              (UInt64)Convert.ChangeType(enumTypeVal, typeof(UInt64));
            prop.SetValue(element, new object[] { val });
          }
        }
      }
      parent.AddChild(element);
    }
  }

  #endregion

  #region Enum read/value
  public static EnumType? ReadEnum<EnumType, ElementType>(this OO.OpenXmlCompositeElement parent)
  where EnumType : struct, IConvertible where ElementType : OO.OpenXmlLeafElement
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
    {
      var valProp = typeof(ElementType).GetProperty("Val");
      if (valProp == null)
        throw new InvalidOperationException($"{typeof(ElementType).Name} does not have Val property");
      var valObj = valProp.GetValue(element, null);
      if (valObj is OO.EnumValue<EnumType> valEnum)
        if (valEnum.HasValue)
          return valEnum.Value;
    }
    return null;
  }

  public static void WriteEnum<ObjectType, ElementType>(this OO.OpenXmlCompositeElement parent, ObjectType? value)
    where ObjectType : struct, IConvertible where ElementType : OO.OpenXmlLeafElement, new()
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
      element.Remove();
    if (value is not null)
    {
      var newElement = new ElementType();
      var valProp = typeof(ElementType).GetProperty("Val");
      if (valProp == null)
        throw new InvalidOperationException($"{typeof(ElementType).Name} does not have Val property");
      valProp.SetValue(newElement, (ObjectType)value);
      parent.AddChild(newElement);
    }
  }
  #endregion

  #region Object read/value
  public static ObjectType? ReadObject<ObjectType, ElementType>(this OO.OpenXmlCompositeElement parent)
    where ObjectType : class, IDocxBasedElement, new() where ElementType : OO.OpenXmlElement
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
    {
      var valObj = new ObjectType { OpenXmlElement = element };
      return valObj;
    }
    return null;
  }

  public static void WriteObject<ObjectType, ElementType>(this OO.OpenXmlCompositeElement parent, ObjectType? value)
    where ObjectType : class, IDocxBasedElement where ElementType : OO.OpenXmlElement, new()
  {
    var newElement = (value!=null) ? value.OpenXmlElement : null;
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element == newElement)
      return;
    if (element != null)
      element.Remove();
    if (newElement is not null)
    {
      parent.AddChild(newElement);
    }
  }
  #endregion

  #region Collection read/value
  public static ObjectType? ReadCollection<ObjectType, ElementType>(this OO.OpenXmlCompositeElement parent)
    where ObjectType : class, IDocxBasedElement, new() where ElementType : OO.OpenXmlCompositeElement
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
    {
      var valObj = new ObjectType { OpenXmlElement = element };
      return valObj;
    }
    return null;
  }

  public static void WriteCollection<ObjectType, ElementType>(this OO.OpenXmlCompositeElement parent, ObjectType? value)
    where ObjectType : class, IDocxBasedElement where ElementType : OO.OpenXmlCompositeElement, new()
  {
    var newElement = (value != null) ? value.OpenXmlElement : null;
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element == newElement)
      return;
    if (element != null)
      element.Remove();
    if (newElement is not null)
    {
      parent.AddChild(newElement);
    }
  }
  #endregion

  #region Relationship read/write
  public static DM.Relationship? ReadRelationshipType<ElementType>(this OO.OpenXmlCompositeElement parent) where ElementType : WD.RelationshipType
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null && element.Id?.HasValue == true)
    {
      return new DM.Relationship{ Id = element.Id?.Value};
    }
    return null;
  }

  public static void WriteRelationshipType<ElementType>(this OO.OpenXmlCompositeElement parent, DM.Relationship? value)
    where ElementType : WD.RelationshipType, new()
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
      element.Remove();
    if (value != null)
    {
      var newElement = new ElementType{ Id = ((DM.Relationship)value).Id };
      parent.AddChild(newElement);
    }
  }
  #endregion

  #region KinsokuSetting read/write
  public static DM.LangText? ReadLangText<ElementType>(this OO.OpenXmlCompositeElement parent) where ElementType : OO.OpenXmlLeafElement
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
    {
      var dmLangText = new DM.LangText();
      var langProp = typeof(ElementType).GetProperty("Language");
      if (langProp != null)
        dmLangText.Lang = (string?)langProp.GetValue(element, null);
      var textProp = typeof(ElementType).GetProperty("Val");
      if (textProp != null)
        dmLangText.Text = (string?)textProp.GetValue(element, null);
      return dmLangText;
    }
    return null;
  }

  public static void WriteLangText<ElementType>(this OO.OpenXmlCompositeElement parent, DM.LangText? value) where ElementType : OO.OpenXmlLeafElement, new()
  {
    var element = parent.Elements<ElementType>().FirstOrDefault();
    if (element != null)
      element.Remove();
    if (value != null)
    {
      var newElement = new ElementType();
      var langProp = typeof(ElementType).GetProperty("Language");
      if (langProp != null)
        if (value.Lang!=null)
          langProp.GetValue(element, new object[] { value.Lang });
      var textProp = typeof(ElementType).GetProperty("Val");
      if (textProp != null)
        if (value.Text != null)
          textProp.GetValue(element, new object[] { value.Text });
      parent.AddChild(newElement);
    }
  }
  #endregion
}