using DX = DocumentFormat.OpenXml;

namespace DocumentModel.Utils;
public static class OpenXmlSimpleTypeUtils
{
  public static Boolean? AsBoolean(this DX.OpenXmlSimpleType? element)
  {
    var str = element?.InnerText;
    if (str!= null)
    {
      if (Boolean.TryParse(str, out var val)) 
        return val;
    }
    return null;
  }

  public static int? AsInt(this DX.OpenXmlSimpleType? element)
  {
    var str = element?.InnerText;
    if (str!= null)
    {
      if (int.TryParse(str, out var val)) 
        return val;
    }
    return null;
  }

    public static Guid? AsGuid(this DX.OpenXmlSimpleType? element)
  {
    var str = element?.InnerText;
    if (str!= null)
    {
      if (Guid.TryParse(str, out var val)) 
        return val;
    }
    return null;
  }
}
