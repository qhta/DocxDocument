using System.ComponentModel;
using System.Xml.Linq;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Font charset converter
/// </summary>
public static class CharsetConverter
{
  /// <summary>
  /// Conversion table used to convert IANA name to charset code.
  /// </summary>
  public static BiDiDictionary<string, DMW.Charset> NameToCharset = new()
  {
    { "iso-8859-1", DMW.Charset.Ansi },
    { "macintosh", DMW.Charset.MacFfn },
    { "shift_jis", DMW.Charset.ShiftJIS },
    { "ks_c-5601-1987", DMW.Charset.Hangul },
    { "ks_C-5601-1992", DMW.Charset.Johab },
    { "GBK", DMW.Charset.GB2312 },
    { "Big5", DMW.Charset.Chinese5 },
    { "windows-1253", DMW.Charset.Greek },
    { "iso-8859-9", DMW.Charset.Turkish },
    { "windows-1258", DMW.Charset.Vietnamese },
    { "windows-1255", DMW.Charset.Hebrew },
    { "windows-1256", DMW.Charset.Arabic },
    { "windows-1257", DMW.Charset.Baltic },
    { "windows-1251", DMW.Charset.Russian },
    { "windows-874", DMW.Charset.Thai },
    { "windows-1250", DMW.Charset.EastEurope },
  };


  public static DMW.Charset? CreateModelElement(DXW.FontCharSet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      if (openXmlElement?.Val?.Value != null)
      {
        string val = openXmlElement.Val.Value;
        if (Byte.TryParse(val, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var code))
        {
          return (DMW.Charset)code;
        }
        else
        if (NameToCharset.TryGetValue2(val, out var charset))
        {
          return charset;
        }
        else
          throw new InvalidOperationException($"Font charset {val} not recognized");
      }
      else
      if (openXmlElement?.StrictCharacterSet?.Value != null)
      {
        var strictSet = openXmlElement.StrictCharacterSet.Value;
        var str = strictSet.ToString().ReplaceStart("chs", "");
        if (str == "Hangeul")
          str = "Hangul";
        if (typeof(DMW.Charset).TryGetEnumValue(str, out var val) && val != null)
          return (DMW.Charset)val;
        else
          throw new InvalidOperationException($"Font charset {val} not recognized");
      }
    }
    return null;
  }

  public static bool CompareModelElement(DXW.FontCharSet? openXmlElement, DMW.Charset? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var origCharset = CreateModelElement(openXmlElement);
      if (origCharset != null)
      {
        var ok = true;
        if (!EnumValueConverter.CmpValue<DMW.Charset>((DMW.Charset)origCharset, value, diffs, objName, propName))
          ok = false;
        return ok;
      }
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Charset value)
    where OpenXmlElementType : DXW.FontCharSet, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.FontCharSet openXmlElement, DMW.Charset value)
  {
    openXmlElement.Val = ((byte)Convert.ChangeType(value, typeof(byte))).ToString("X2");
  }
}
